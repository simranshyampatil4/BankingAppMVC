using BankingAppMVC.Assemblers;
using BankingAppMVC.Services;
using BankingAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingAppMVC.Controllers
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        // GET: Customer


        public ActionResult Index()
        {
            var customers = _customerService.GetAll();
            var customerVMs = customers.Select(c => _customerAssembler.ConvertToViewModel(c)).ToList();
            return View(customerVMs);
        }

        private readonly ICustomerService _customerService;
        private readonly CustomerAssembler _customerAssembler;
        public CustomerController(ICustomerService customerService, CustomerAssembler customerAssembler)
        {
            _customerService = customerService;
            _customerAssembler = customerAssembler;
        }
       


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerVM customerVM)
        {
            var customer = _customerAssembler.ConvertToModel(customerVM);
            var newCustomer = _customerService.Add(customer);
            ViewBag.Message = "Added Successfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var customerData = _customerService.GetById(id);
            var customerDataVM = _customerAssembler.ConvertToViewModel(customerData); 
            return View(customerDataVM);
        }
        [HttpPost]
        public ActionResult Edit(CustomerVM userVM)
        {
            var user = _customerService.GetById(userVM.Id); 
            if (user != null)
            {
                _customerService.Update(user);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var customerData = _customerService.GetById(id); 
            var customerDataVM = _customerAssembler.ConvertToViewModel(customerData);
            return View(customerDataVM);
        }
        [HttpPost]
        public ActionResult Delete(CustomerVM customerVM)
        {
            var customer = _customerService.GetById(customerVM.Id);
            if (customer != null)
            {
                _customerService.Delete(customer);
            }
            return RedirectToAction("Index");
        }
    }

}
