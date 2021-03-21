using ConsoleServiceTopShelf.Rotinas;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleServiceTopShelfQuartz
{
    public static class ExecutaRotinasQuartz
    {
        private static IScheduler scheduler { get; set; }
        public static bool flExecute { get; set; } = true;

        public static async void StartaRotinas()
        {
            Console.WriteLine("Iniciado Robo de Rotina de Alertas!");

            StdSchedulerFactory factory = new StdSchedulerFactory();

            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<RotinaLembrete>()
                .WithIdentity("myJob", "group1")
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(17, 50))
                .Build();

            await scheduler.ScheduleJob(job, trigger);            
            await scheduler.Start();
        }

        public async static void StopaRotina()
        {
            flExecute = false;
            Console.WriteLine("Encerado Robo de Rotina de Alertas!");
            if(scheduler != null)
                await scheduler.Shutdown();
        }
    }
}
