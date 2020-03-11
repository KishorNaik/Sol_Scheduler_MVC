using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspNetCore.Scheduler.ScheduleTask;
using System.IO;

namespace Sol_Demo.Schedulers
{
    public class ScheduleTask : IScheduledTask
    {
        public string Schedule => "39 6 * * *";

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            string someText = "C# Corner is a community of software and data developers";
            File.WriteAllText(@"C:\csc.txt", someText);

            await Task.CompletedTask;
        }
    }
}