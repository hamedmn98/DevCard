using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(id:1, title:"آموزش Asp" , description:"پکیج آموزشی" , image:"blog-post-thumb-card-1.jpg"),
                new Article(id:2, title:"آموزش git" , description:"پکیج آموزشی asp" , image:"blog-post-thumb-card-2.jpg"),
                new Article(id:3, title:"آموزش onion" , description:"پکیج آموزشی onion" , image:"blog-post-thumb-card-3.jpg"),
                new Article(id:4, title:"آموزش site" , description:"پکیج آموزشی site" , image:"blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles", articles);

        }
    }
}
