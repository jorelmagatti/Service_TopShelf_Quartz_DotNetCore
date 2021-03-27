using ConsoleServiceTopShelf;
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
            int horas = 17;
            int minutos = 25;

            Console.WriteLine("Iniciado Robo de Encerrar processo de Alertas!");
            Console.WriteLine($"Rotina Diária progamada para as {horas}:{minutos}!");
            LogLocal.Log($"Rotina Diária progamada para as {horas}:{minutos}!");

            StdSchedulerFactory factory = new StdSchedulerFactory();

            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<RotinaEncerraProcesso>()
                .WithIdentity("myJob", "group1")
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(horas, minutos))
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
