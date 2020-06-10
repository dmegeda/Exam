using Exam.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.PresentationLayer.Controllers
{
    public class DepartmentController : Controller
    {
        IControlDepartmentService depService;

        public DepartmentController(IControlDepartmentService service)
        {
            depService = service;
        }

        void DeleteItem() { }

        void GetItem() { }

        void GetAll() { }

        void CreateItem() { }

        void UpdateItem() { }

        void AddItemToDepartment() { }
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
    }
}