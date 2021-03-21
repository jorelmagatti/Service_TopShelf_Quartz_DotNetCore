using Quartz;
using System;
using Quartz.Impl;
using System.Threading.Tasks;
using BibliotecasDeRotinas;

namespace ConsoleRotinaComQuartz
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Iniciado Robo de Rotina basica!");

            StdSchedulerFactory factory = new StdSchedulerFactory();

            // get a scheduler
            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<SimpleJob>()
                .WithIdentity("myJob", "group1")
                .Build();

            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(5)
                    .RepeatForever())
            .Build();

            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();

            Console.ReadKey();
            await scheduler.Shutdown();
        }
    }
}
