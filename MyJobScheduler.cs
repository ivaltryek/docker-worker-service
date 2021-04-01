using Coravel.Invocable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace docker_worker_service
{
    public class MyJobScheduler : IInvocable
    {
        public Task Invoke()
        {
            File.AppendAllText("logs.txt", "This is called at: " + DateTime.Now.ToString() + Environment.NewLine);
            Console.WriteLine("This is called at: " + DateTime.Now.ToString() + Environment.NewLine);
            return Task.CompletedTask;
        }
    }
}