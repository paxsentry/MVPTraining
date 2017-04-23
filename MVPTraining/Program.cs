using System;
using System.Windows.Forms;

namespace MVPTraining
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new StartingForm();
            var view1 = mainForm.InstanceOfUserControlOne;
            var presenter = new ZoltanPresenter(view1);

            Application.Run(new StartingForm());
        }
    }
}
