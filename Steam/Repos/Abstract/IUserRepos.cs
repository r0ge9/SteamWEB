using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steam.Repos.Abstract
{
    public interface IUserRepos
    {
        IQueryable<User> GetUser();
        User GetUserById(string id);
        void SaveUser(User user);
        void DeleteUser(string id);
    }
}
