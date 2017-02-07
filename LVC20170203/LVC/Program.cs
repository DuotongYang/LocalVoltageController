// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
using System.Windows.Forms;
using ECAClientFramework;
using LVC.Model;

namespace LVC
{
    static class Program
    {
        /// <summary>
        /// Main entry point for LVC.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Framework framework = new Framework(fw => new Mapper(fw));

            Algorithm.UpdateSystemSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow mainWindow = new MainWindow(framework);
            mainWindow.Text = "C# LVC Test Harness";
            Application.Run(mainWindow);
        }
    }
}