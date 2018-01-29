using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{   /*************************
     * Description:how to display info from two  related tables and modify them
     * Date:Jan 9 ,2018
     * Authour:Haishu Zhu
     * Course Code:CPRG200
     **************************/
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
            Application.Run(new frmOrderMaintenance());
        }
    }
}
