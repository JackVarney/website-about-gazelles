using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRedux;
using WebsiteAboutGazells.Shared.Models;

namespace WebsiteAboutGazells.Client.Shared.Store
{    
    public class GetGazelles : IAction
    {
        public IEnumerable<Gazelle> Gazelles { get; set; }
    }    
}
