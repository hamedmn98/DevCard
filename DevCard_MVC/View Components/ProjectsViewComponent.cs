using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1, name:"تاکسی" , "درخواست آنلانین تاکسی ", image:"project-1.jpg" , client:"Atriya"),
                new Project(id:2, name:"زودفود" , description: "درخواست آنلانین غذا ", image:"project-2.jpg" , client:"ZoodFood"),
                new Project(id:3, name:"مدارس" , description:"سیستم مدریت یکپارچه ", image:"project-3.jpg" , client:"Monop"),
                new Project(id:4, name:"فضاپیما" , description:"برنامه مدیریت فضاپیما ", image:"project-4.jpg" ,client:"NASA"),
            };
            return View("_Projects",projects);
        }
    }
}
