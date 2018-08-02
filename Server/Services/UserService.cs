using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Server.Models;

namespace Server.Services {
    public class UserService : IUserService {
        Random r;
        string[] userNames;
        public UserService() {
            r = new Random();
            userNames = new[] { "Mary", "Tom", "Ann", "Will", "Jake", "Alise" };
        }

        public IEnumerable<User> GetUsers(int count) {
            List<User> users = new List<User>();
            for (int i = 0; i < count; i++) {
                User user = new User {
                    Id=r.Next(0,61),
                    Name=userNames[r.Next(0, userNames.Length)]
                };
                users.Add(user);
            }
            return users;
        }
    }
}
