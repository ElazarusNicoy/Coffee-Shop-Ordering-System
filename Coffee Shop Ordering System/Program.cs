using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement;


namespace Coffee_Shop_Ordering_System
{
    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;
            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms,
                    //end the program
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };
                form.Show();
            }
        }
    }
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
            //opens all three
            // Application.Run(new MultiFormContext(new frmWelcome(), new frmLogin(), new frmLogin()));

            //proposal1 - 35k-45k
            //Application.Run(new OrderingSystem());

            //proposal2 - 30k-60k
            // Application.Run(new frmWelcome());
            //Application.Run(new frmWelcome(), new frmLogin()));
            //Application.Run(new MultiFormContext(new frmLogin(), new frmLogin(), new frmLogin()));

            //Application.Run(new MultiFormContext(new frmWelcome(), new frmLogin(), new frmLogin()));
            Application.Run(new frmLogin());
        }
    }
}

//ang system ay focus sa ordering, inventory at payment
//wala muna itong mga sales report
