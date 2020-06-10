using Exam.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.PresentationLayer.Controllers
{
    public class ItemController : Controller
    {
        IControlItemService itemService;

        public ItemController(IControlItemService service)
        {
            itemService = service;
        }

        void DeleteItem() { }

        void GetItem() { }

        void GetAll() { }

        void CreateItem() { }

        void UpdateItem() { }
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
    }
}