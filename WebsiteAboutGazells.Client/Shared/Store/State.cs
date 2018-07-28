using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteAboutGazells.Shared.Models;

namespace WebsiteAboutGazells.Client.Shared.Store
{
    public class State
    {
        public IEnumerable<Gazelle> Gazelles { get; set; }
    }
}
