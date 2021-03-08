using Quartz;
using Quartz.Impl;
using Quartz.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWebApp
{
    public class JobScheduler
    {
        public async void Start()
        {

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<EmailJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()

                .WithIdentity("HelloJob ", "GreetingGroup")

                .WithCronSchedule("0 0/1 * 1/1 * ? *")// Referrring to the quartz documentation

                .StartAt(DateTime.UtcNow)

                .WithPriority(1)

                .Build();

            await scheduler.ScheduleJob(job, trigger);
        }
    }
}