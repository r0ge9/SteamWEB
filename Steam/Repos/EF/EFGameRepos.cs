using Steam.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steam.Repos.EF
{
    public class EFGameRepos:IGameRepos
    {
        private readonly EFDBContext context;
        public EFGameRepos(EFDBContext context)
        {
            this.context = context;
        }
        public IQueryable<Games> GetGame()
        {
            return context.Games;
        }
        public Games GetGameById(int id)
        {
            return context.Games.FirstOrDefault(x => x.Id == id);
        }
        public void SaveGame(Games game)
        {
            if (game.Id == default)
                context.Entry(game).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(game).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteGame(int id)
        {
            context.Games.Remove(new Games() { Id = id });
            context.SaveChanges();
        }
    }
}
