using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using Console = System.Console;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added : "  + game.Name );
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted : " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game information updated : " + game.Name);
        }
    }
}
