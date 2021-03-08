using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace testWebApp
{
    public class EmailJob : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            Task taskA = new Task(() => Debug.WriteLine("Hello from task at {0}", DateTime.Now.ToString()));
            taskA.Start();
            return taskA;
        }
    }
}