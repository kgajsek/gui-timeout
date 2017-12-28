using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITimeout {
    public static class Program {
        public static int exitCode = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main (string [] args) {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);

            var f = new Form1 ();
            f.timeLeft = TimeSpan.FromSeconds (Convert.ToInt32 (args [0]));

            if (args.Length > 1) { f.SetInfo (args [1]); }
            if (args.Length > 2) { f.SetOKBtn (args [2]); }
            if (args.Length > 3) { f.SetCancelBtn (args [3]); }

            Application.Run (f);

            return exitCode;
        }
    }
}
