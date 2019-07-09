using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    //класс контроллера 
    public class HomeController : Controller
    {
        
        /// <summary>
        /// подключение к базе данных
        /// </summary>
        private Models.ShopDBEntities bd = new Models.ShopDBEntities();

        // GET: /Home/
        public ActionResult Index()
        {

            var Items = bd.Cars; //Выберем все данные из таблицы карс

            return View(Items);
        }
    }
}