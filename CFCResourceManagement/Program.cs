using System;
using System.Threading;
using System.Windows.Forms;

namespace CFCResourceManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        
        static Mutex mutex = new Mutex(true, "8656766f-06d3-4b0b-9ba5-50f12da757ef");

        [STAThread]
        static void Main()
        {

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("only one instance at a time");
            }
            //Khi form chính (form1) bị đóng <==> chương trình kết thúc ấy

        }

    }
}