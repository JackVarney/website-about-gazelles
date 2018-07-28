using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRedux;

namespace WebsiteAboutGazells.Client.Shared.Store
{
    public class Reducer
    {
        public static State RootReducer(State state, IAction action)
        {
            switch(action)
            {
                case GetGazelles a:
                {
                    state.Gazelles = a.Gazelles;
                    return state;
                }

                default:
                {
                    return state;
                }
            }
        }
    }
}
