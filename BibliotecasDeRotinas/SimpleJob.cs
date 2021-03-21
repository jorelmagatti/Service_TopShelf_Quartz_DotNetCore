using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasDeRotinas
{
    public class SimpleJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() => {
                Console.WriteLine("Hello, JOb executed");
            });
        }
    }
}
