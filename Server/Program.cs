using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Server.Services;

namespace Server {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(UserService))) {
                host.Opening += Host_Opening;
                host.Opened += Host_Opened;
                host.Open();
                Console.ReadLine();
            }
        }

        private static void Host_Opened(object sender, EventArgs e) {
            Console.WriteLine("service is ready...");
        }

        private static void Host_Opening(object sender, EventArgs e) {
            Console.WriteLine("opening service...");
        }
    }
}
