using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService3
{
    
    public partial class Service3 : ServiceBase
    {
        public System.Timers.Timer TimerServicio = new System.Timers.Timer();
        public Service3()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TimerServicio = new System.Timers.Timer();
            TimerServicio.Elapsed += (_, __) => EjecutaUnaAccion();
            TimerServicio.Interval = 60000;
            TimerServicio.Start();
        }
        public void EjecutaUnaAccion()
        {
            int i;
            for (i = 1; i <= 1000; i++)
{
                File.AppendAllText(@"C:\WindowsService3\bin\Debug\InformeC#.TXT", "Línea C# N° " + i + System.Environment.NewLine);
} 
       }
        protected override void OnStop()
        {
            TimerServicio.Close();
        }
        protected override void OnPause()
        {
            TimerServicio.Stop();
        }
        protected override void OnContinue()
        {
            TimerServicio.Start();
        }
    }
}
