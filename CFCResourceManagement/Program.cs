using System;
using Serilog.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;

using Serilog;
using Serilog.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace CFCResourceManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        private static readonly IHost _host
         = Host.CreateDefaultBuilder()
                //Ilogger ở tất cả các constructor sẽ được tự động tiêm giá trị do Serilog là một
                //package sử dụng thay thế cho Logger của Microsoft. Serilog sẽ hỗ trợ lưu file,
                //hoặc viết ra console có màu nhấn mạnh dễ đọc.
                .UseSerilog((host, loggerConfiguration) =>
                {
                    loggerConfiguration
                        //Viết log hệ thống ra file test.txt, mỗi ngày tạo 1 file
                        .WriteTo.File("logs/trace.log", rollingInterval: RollingInterval.Day)

                        //WriteTo Console và Debug không hoạt động ở Winform .NetCore 5.0
                        //(mình chữa rõ lý do, cũng ko ảnh hưởng vì log này có file text dễ dùng rồi.
                        //.WriteTo.Debug()

                        //Level tối thiểu sẽ pass để chuyển lưu vào log hoặc hiển thị ra console 
                        // ở các dự án web hoặc wpf khác vì console, debug ko thấy chạy ở winform này 
                        //như đã trình bày ở trên
                        .MinimumLevel.Verbose()
                        /*.MinimumLevel.Override("WinFormsApp3.Form1", Serilog.Events.LogEventLevel.Debug)*/;
                }).ConfigureServices(
             services =>
             {
                 services.AddSingleton<frmMain>();
                 services.AddScoped<frmMain>();


             }).Build();

        static Mutex mutex = new Mutex(true, "8656766f-06d3-4b0b-9ba5-50f12da757ef");

        [STAThread]
        static void Main()
        {
            _host.Start();
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var formMain = _host.Services.GetRequiredService<frmMain>();
                Application.Run(formMain);
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("only one instance at a time");
            }
                //Khi form chính (form1) bị đóng <==> chương trình kết thúc ấy
                //thì dừng host
                _host.StopAsync().GetAwaiter().GetResult();

            //và giải phóng tài nguyên host đã sử dụng.
            _host.Dispose();
        }


    }
}