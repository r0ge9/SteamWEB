using DataLayer.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class DataManager
    {
        public IUserRepos User { get; set; }
        public IGameRepos Game { get; set; }
        public DataManager(IUserRepos userRepos,IGameRepos gameRepos)
        {
            User = userRepos;
            Game = gameRepos;
        }
    }
}
