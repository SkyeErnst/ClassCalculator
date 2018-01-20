using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculater
{
    public static class MainProgram
    {
        #region Internal Fields

        internal readonly static MainForm mainFormRef;

        #endregion

        static MainProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainFormRef = new MainForm();
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
