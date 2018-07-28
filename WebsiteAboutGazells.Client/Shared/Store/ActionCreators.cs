using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorRedux;
using Microsoft.AspNetCore.Blazor;
using WebsiteAboutGazells.Shared.Models;

namespace WebsiteAboutGazells.Client.Shared.Store
{
    public class ActionCreators
    {
        public static async Task LoadGazelles(Dispatcher<IAction> dispatch, HttpClient http)
        {
            var gazelles = await http.GetJsonAsync<Gazelle[]>("api/gazelles");
            dispatch(new GetGazelles { Gazelles = gazelles });
        }
    }
}
