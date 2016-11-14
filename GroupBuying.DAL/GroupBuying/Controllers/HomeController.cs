using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupBuying.DAL;
using GroupBuying.DAL.Model;

namespace GroupBuying.Controllers
{
    public class HomeController : Controller
    {
        GroupBuyingContext db = new GroupBuyingContext();
        public ActionResult Index()
        {
            //GroupBuyingInitializer init = new GroupBuyingInitializer();
            DAL.Model.User user = new DAL.Model.User() {
                Id = 3535,FirstName = "sara",
                LastName = "Choen", IsAdmin = false,
                CreditExpiration = new DateTime(),
                CreditNumber = "32586", Mail = "sara@gmail.com" };
            db.Users.Add(user);
            db.SaveChanges();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
