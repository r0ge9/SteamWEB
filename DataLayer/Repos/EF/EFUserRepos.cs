using DataLayer.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repos.EF
{
    public class EFUserRepos:IUserRepos
    {
        private readonly EFDBContext context;
        public EFUserRepos(EFDBContext context)
        {
            this.context = context;
        }
        public IQueryable<User> GetUser()
        {
            return context.User;
        }
        public User GetUserById(int id)
        {
            return context.User.FirstOrDefault(x => x.Id == id);
        }
        public void SaveUser(User user)
        {
            if (user.Id == default)
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            context.User.Remove(new User() { Id = id });
            context.SaveChanges();
        }
    }
}
