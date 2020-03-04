using ACTech.Models;
using ACTech.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ACTech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        private List<Transcript> _grade;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, RoutedEventArgs e)
        {
            DataService _dataService = new DataService();
            string studentid = searchbox.Text;
            _grade = _dataService.Get(studentid);
            dgStudent.ItemsSource = _grade;
        }


        private void transcriptButton_Click(object sender, RoutedEventArgs e)
        {
            TranscriptService _transcriptService = new TranscriptService();
            _transcriptService.CreateTranscript(_grade);
        }
    }
}
