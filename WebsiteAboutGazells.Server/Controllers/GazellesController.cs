using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteAboutGazells.Server.Services;
using WebsiteAboutGazells.Shared.Models;

namespace WebsiteAboutGazells.Server.Controllers
{
    [Route("api/[controller]")]
    public class GazellesController : Controller
    {
        [HttpGet]
        public IEnumerable<Gazelle> Get()
        {
            return GazelleService.Get();
        }
    }
}