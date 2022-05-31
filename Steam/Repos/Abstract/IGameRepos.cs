using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steam.Repos.Abstract
{
    public interface IGameRepos
    {
        IQueryable<Games> GetGame();
        Games GetGameById(int id);
        void SaveGame(Games user);
        void DeleteGame(int id);
    }
}
