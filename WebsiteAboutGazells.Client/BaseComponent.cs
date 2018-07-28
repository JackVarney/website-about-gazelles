using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRedux;
using WebsiteAboutGazells.Client.Shared.Store;

namespace WebsiteAboutGazells.Client
{
    public class BaseComponent : ReduxComponent<State, IAction>
    {
    }
}
