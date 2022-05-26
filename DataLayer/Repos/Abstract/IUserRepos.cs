using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repos.Abstract
{
    public interface IUserRepos
    {
        IQueryable<User> GetUser();
        User GetUserById(int id);
        void SaveUser(User user);
        void DeleteUser(int id);
    }
}
