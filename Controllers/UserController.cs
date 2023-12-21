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
    public class UserController : Controller
    {
        private readonly IUserService _userService; private readonly UserAssembler _userAssembler;
        public UserController(IUserService userService, UserAssembler userAssembler)
        {
            _userService = userService; _userAssembler = userAssembler;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserVM userVM)
        {
            var user = _userAssembler.ConvertToModel(userVM); var newUser = _userService.Add(user);
            ViewBag.Message = "Added Successfully"; return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var userData = _userService.GetById(id);
            var userDataVM = _userAssembler.ConvertToViewModel(userData); return View(userDataVM);
        }
        [HttpPost]
        public ActionResult Edit(UserVM userVM)
        {
            var user = _userService.GetById(userVM.Id); if (user != null)
            {
                _userService.Update(user);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var userData = _userService.GetById(id); var userDataVM = _userAssembler.ConvertToViewModel(userData);
            return View(userDataVM);
        }
        [HttpPost]
        public ActionResult Delete(UserVM userVM)
        {
            var user = _userService.GetById(userVM.Id);
            if (user != null)
            {
                _userService.Delete(user);
            }
            return RedirectToAction("Index");
        }
    }
}