using ConsoleServiceTopShelf.Rotinas;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleServiceTopShelfQuartz
{
    public static class ExecutaRotinasQuartz
    {
        private static IScheduler scheduler { get; set; }

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
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(10, 00))
                .Build();

            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();

            Console.ReadKey();

        }

        public async static void StopaRotina()
        {
            Console.WriteLine("Encerado Robo de Rotina de Alertas!");
            await scheduler.Shutdown();
        }
    }
}
