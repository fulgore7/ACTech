using ACTech.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Words.MailMerging;
using System.IO;
using System.Linq;
using System.Text;
using Aspose.Words;
using System.Data;
using System.Reflection;

namespace ACTech.Services
{
    public class TranscriptService
    {
        public static String GetDataDir;
        public static string fileName = "MailMerge.ACTech" + DateTime.Now.ToShortDateString() +".doc" ;
        private EmailService _emailService = new EmailService();
        public void CreateTranscript(List<Transcript> grade)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath(GetDataDir_Data() + "Mail-Merge/");
            Document doc = new Document(dataDir + "Actech-Transcript-Template.dot");
            //doc.MailMerge.MergeDuplicateRegions = true;
            //doc.MailMerge.MergeWholeDocument = true;
            ListtoDataTable lsttodt = new ListtoDataTable();
            DataTable dt = lsttodt.ToDataTable(grade);
            dt.TableName = "Grades";
            doc.MailMerge.Execute(dt);
            doc.MailMerge.ExecuteWithRegions(dt);
            
            dataDir = dataDir + GetOutputFilePath(fileName);
            doc.Save(dataDir);
            _emailService.CreateEmail(dataDir);
        }
        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }

            return Path.Combine(startDirectory, "Data\\");
        }

        public static string GetOutputFilePath(String inputFilePath)
        {
            string extension = Path.GetExtension(inputFilePath);
            string filename = Path.GetFileNameWithoutExtension(inputFilePath);
            return filename + "_out" + extension;
        }
    }

    public class ListtoDataTable
    {
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}

