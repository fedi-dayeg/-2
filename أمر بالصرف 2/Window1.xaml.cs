using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using System.Windows.Shapes;

using CrystalDecisions.CrystalReports.Engine;

namespace أمر_بالصرف_2
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public static Connexion conn;
        public OleDbConnection Connexion;
        public OleDbCommand command;
        Ordre or = new Ordre();
        public Window1()
        {
            InitializeComponent();
           /*var cryRpt = new ReportDocument();
            cryRpt.Load($"../../CrystalReport2.rpt");

            crystalReportViewer1.ViewerCore.ReportSource = cryRpt;*/
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void widows_loaded(object sender, RoutedEventArgs e)
        {
           /*CrystalReport2 crystal = new CrystalReport2();
           crystal.Load(@"CrystalReport2.rep");
           crystalReportViewer1.ViewerCore.ReportSource = crystal;*/
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }
    }
}
