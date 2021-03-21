using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceTopShelf.Rotinas
{
    public class RotinaLembrete : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() => {
                Console.WriteLine("Lembrete iniciado");
                ChamaLembrete();
            });
        }

        public void ChamaLembrete()
        {
            try
            {
                //string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //string appWindowsForms = dir.Replace("ConsoleServiceTopShelf", "Alerta").Replace("\\netcoreapp3.1", "") + "\\Alerta.exe";
                string appWindowsForms = @"C:\Users\ab1232338\source\repos\jorelmagatti\Service_TopShelf_Quartz_DotNetCore\Alerta\bin\Debug\Alerta.exe";

                EncerraProcessAlerta();

                Process pro = new Process();
                pro.StartInfo.FileName = appWindowsForms;
                pro.StartInfo.Arguments = "Buscar a Preciosa no trabalho!!!";
                pro.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                pro.Start();
                pro.WaitForExit();
            }
            catch (Exception) { }
        }

        public void EncerraProcessAlerta()
        {
            try
            {
                var alerta = Process.GetProcessesByName("Alerta");
                if(alerta != null)
                {
                    foreach (var item in alerta)
                    {
                        item.Kill();
                    }
                }                   
            }
            catch (Exception) { }
        }
    }
}
