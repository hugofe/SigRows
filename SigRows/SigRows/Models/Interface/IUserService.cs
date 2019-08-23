using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRows.Models.Interface
{
    public interface IUserService
    {
        User Create(User user);
        User Read(int id_user);
        User Update(User user);
        void Delete(User user);
    }
}
