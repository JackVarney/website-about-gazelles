using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteAboutGazells.Shared.Models;

namespace WebsiteAboutGazells.Server.Services
{
    public class GazelleService
    {
        private static List<Gazelle> Gazelles = new List<Gazelle>()
        {
            new Gazelle(
                1,
                "Thomson's Gazelle",
                "Common Gazelle in Africa - really really fast, like 5th fastest fast!"
            ),
            new Gazelle (                
                2,
                "Mongolian gazelle",
                "Guess where its from? Thats right - Mongolia."
            )
        };

        public static IEnumerable<Gazelle> Get()
        {
            return Gazelles.ToArray();
        }

        public static Gazelle GetById(int id)
        {
            return Gazelles.Find(g => g.Id == id);
        }
    }
}
