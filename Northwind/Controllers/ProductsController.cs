using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Northwind.Models;
using Northwind.Controllers;

namespace Northwind.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext_context;
        private readonly ICurrent_currentUser;

        public ProductsController(ApplicationDbContext context, ICurrentUser currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public ActionResult Index()
        {
            var models = ContextBoundObject.Products.Project().To<ProductViewModel>().ToArray();
            return View(models);
        }
    }
}