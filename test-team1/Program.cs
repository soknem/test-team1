using System;
using System.Windows.Forms;
using test_team1.Dal;
using test_team1.Ui;

namespace test_team1


{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseSetup.InsertSampleData();
            Application.Run(new StudentForm());
            //Application.Run(new Form2());
        }
    }
}

