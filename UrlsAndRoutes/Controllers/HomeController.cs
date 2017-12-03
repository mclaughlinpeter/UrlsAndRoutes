using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes.Models;
using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result", new Result
        {
            Controller = nameof(HomeController),
            Action = nameof(Index)
        });
    }
}
