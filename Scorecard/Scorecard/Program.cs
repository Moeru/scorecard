using Scorecard.Controller;
using Scorecard.View;
using System;
using System.Windows.Forms;

namespace Scorecard
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

            var controller = new ApplicationController();
            var window = new MainWindow(controller);

            Application.Run(window);
        }
    }
}
