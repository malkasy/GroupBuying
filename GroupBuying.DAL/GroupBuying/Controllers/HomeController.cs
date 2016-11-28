using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupBuying.DAL;
using GroupBuying.DAL.Model;
using System.Web.Http;
using System.Web.Http.Description;



namespace GroupBuying.Controllers
{
    public class HomeController : ApiController
    {
        GroupBuyingContext db = new GroupBuyingContext();
        public List<User> Users = new List<DAL.Model.User>();
        public List<Item> Items = new List<Item>();
        [System.Web.Http.Route("home/index")]
        [System.Web.Http.HttpGet]
        [ResponseType(typeof(Item))]
        public IHttpActionResult Index()
        {

            Item item = new Item()
            {
                Name = "Bosh washing machine",
                Description = " Model:A123 contains 10k",
                Price = 2000.00,
                CategoryId = db.Categories.FirstOrDefault(x => x.Name.Equals("electricity"))
            };
            //GroupBuyingInitializer init = new GroupBuyingInitializer();
            //DAL.Model.User user = new DAL.Model.User() {
            //    Id = 3535,FirstName = "sara",
            //    LastName = "Choen", IsAdmin = false,
            //    CreditExpiration = new DateTime(),
            //    CreditNumber = "32586", Mail = "sara@gmail.com" };
            Items.Add(item);
            //ViewBag.Title = "Home Page";

            return Ok(Items);
        }


        [System.Web.Http.Route("home/get")]
        [ResponseType(typeof(User))]
        public IHttpActionResult Get()
        {
            DAL.Model.User user = new DAL.Model.User()
            {
                Id = 3535,
                FirstName = "sara",
                LastName = "Choen",
                IsAdmin = false,
                CreditExpiration = DateTime.Now,
                CreditNumber = "32586",
                Mail = "sara@gmail.com"
            };
            db.Users.Add(user);
            db.SaveChanges();
            User u = db.Users.Find(3535);
            Users.Add(user);
            
            return Ok(Users);
        }

       

    }
}
