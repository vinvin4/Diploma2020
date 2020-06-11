using Diploma2020.Screens;
using System;
using System.Windows.Forms;

namespace Diploma2020
{
    static class StartFile
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelkomeScreen());
            Application.Run(new ChooseFunctionality());
        }
    }
}
