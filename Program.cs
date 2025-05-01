using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorFinanceiro
{
    static class Program
    {
        //public static string conexaoBD = "server=localhost;database=db_monitor;uid=root;pwd=ernandes";
        public static string conexaoBD = "server=localhost;database=db_monitor;uid=root;pwd=123456";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
