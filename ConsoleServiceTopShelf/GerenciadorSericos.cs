using Topshelf;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleServiceTopShelfQuartz
{
    public class GerenciadorSericos
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<MeuServicoWS>(service =>
                {
                    service.ConstructUsing(s => new MeuServicoWS());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                //Configure a Conta que o serviço do Windows usa para rodar
                configure.RunAsLocalSystem();
                configure.SetServiceName("MeuServicoWindowsComTopshelf");
                configure.SetDisplayName("MeuServicoWindowsComTopshelf");
                configure.SetDescription("Meu serviço Windows com Topshelf");
            });
        }
    }
}
