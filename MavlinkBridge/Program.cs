using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MavlinkBridge
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Application.Run(new MainForm());
        }
    }
}
