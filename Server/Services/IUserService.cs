using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Server.Models;

namespace Server.Services {
    [ServiceContract]
    public interface IUserService {
        [OperationContract]
        IEnumerable<User> GetUsers(int count);
    }
}
