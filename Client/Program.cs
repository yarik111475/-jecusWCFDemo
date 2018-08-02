using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.localhost;

namespace Client {
    class Program {
        static void Main(string[] args) {
            IEnumerable<User> users;
            using (UserServiceClient proxy = new UserServiceClient()) {
                users = proxy.GetUsers(1000000);
            }
            foreach (User user in users) {
                Console.WriteLine(user);
            }
            Console.ReadLine();
        }
    }
}
