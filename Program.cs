using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMS
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Formlogin f = new Formlogin();
            if(f.ShowDialog()==DialogResult.OK)
            {
             Application.Run(new FormMain(f.PersonModel));
            }
            
        }
    }
}
