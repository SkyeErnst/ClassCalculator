using System;
using System.Windows.Forms;

namespace ClassCalculater
{
    public static class MainProgram
    {
        #region Internal Fields

        internal readonly static MainForm mainFormRef;
        internal readonly static IOManager ioManRef;
        internal readonly static MainFormAssistant assistant;

        #endregion

        static MainProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainFormRef = new MainForm();
            ioManRef = new IOManager();
            assistant = new MainFormAssistant();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.Run(mainFormRef);
        }
    }
}