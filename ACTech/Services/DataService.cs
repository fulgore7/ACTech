using ACTech.Data;
using ACTech.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ACTech.Services
{
    public class DataService
    {
        private ActechContext _context;
        public DataService()
        {
            _context = new ActechContext();
        }
        public IQueryable<Grade> GetAllGrades()
        {
            return _context.Grades.AsQueryable();
        }
        public List<Transcript> Get(string id)
        {
            //List<Grade> entity = GetAllGrades().Where(b => b.StudentId == id).ToList<Grade>();
            var entity = _context.Grades.Include(G => G.Student).Include(G => G.Course).Where(b => b.StudentId == id)
                .Select(G => new Transcript()
                {
                    Fname = G.Student.Fname,
                    Mi = G.Student.Mi,
                    Lname = G.Student.Lname,
                    Dob = G.Student.Dob,
                    Address = G.Student.StudentAddresses.FirstOrDefault<StudentAddress>().Address,
                    CityStateZip = G.Student.StudentAddresses.FirstOrDefault<StudentAddress>().City.Trim() + ", " + G.Student.StudentAddresses.FirstOrDefault<StudentAddress>().State +" " + G.Student.StudentAddresses.FirstOrDefault<StudentAddress>().Zip,
                    Phone = G.Student.StudentContacts.FirstOrDefault<StudentContact>().HomePhone,
                    Sem = G.Sem,
                    CourseName = G.Course.Course1,
                    PreAssessment = G.PreAssessment,
                    S1 = G.S1,
                    S2 = G.S2,
                    S3 = G.S3,
                    S4 = G.S4,
                    S5 = G.S5,
                    S6 = G.S6,
                    S7 = G.S7,
                    S8 = G.S8,
                    S9 = G.S9,
                    S10 = G.S10,
                    Adj = G.Adj,
                    Ojt = G.Ojt,
                    Cert = G.Cert
                }).ToList();
            return entity;
        }
    }
}
