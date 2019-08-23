using SigRows.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRows.Models.Service
{
    public class UserService : IUserService
    {
        private readonly User _user;
        public UserService(User user)
        {
            _user = user;
        }
        public User Create(User user)
        {
             
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public User Read(int id_user)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
