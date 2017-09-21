using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PandaBookStore.WebApp.Models;

namespace PandaBookStore.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var thread = new TaskThread();
            //thread.InitTimer();
            BuildWebHost(args).Run();            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()                
                .Build();
    }
}
