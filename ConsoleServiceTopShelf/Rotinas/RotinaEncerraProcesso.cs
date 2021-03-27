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
    public class RotinaEncerraProcesso : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            LogLocal.Log($"Rotina Iniciada conforme programado as {DateTime.Now}");
            return Task.Run(() => {
                EncerraProcessAlerta();
            });
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
                        LogLocal.Log($"Processo Alerta Encerrado");
                    }
                }                   
            }
            catch (Exception ex) { LogLocal.Log($"Ex EncerraProcessAlerta() : {ex}\r\n{ex.Message}\r\n{ex.StackTrace}");  }
        }
    }
}
