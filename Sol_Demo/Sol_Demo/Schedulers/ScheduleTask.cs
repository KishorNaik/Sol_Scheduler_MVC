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
            string someText = "Hello I am .Net Core Developer";
            File.WriteAllText(@"C:\demo.txt", someText);

            await Task.CompletedTask;
        }
    }
}