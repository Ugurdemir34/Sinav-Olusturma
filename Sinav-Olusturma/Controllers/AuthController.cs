﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.DataAccess.Concrete.EntityFramework;
using Sinav_Olusturma.Entities.Dtos;

namespace Sinav_Olusturma.Controllers
{
    public class AuthController : Controller
    {
       
        private IAuthService _authService;
        private IHttpContextAccessor _httpContextAccessor;
        public AuthController(IHttpContextAccessor httpContextAccessor, IAuthService authService)
        {
            _authService = authService;          
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {        
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDto model)
        {
            var result = _authService.Login(model);
            if (result != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("Name",model.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                _httpContextAccessor.HttpContext.Session.SetString("username", result.Username);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                ViewData["mesaj"] = "";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["mesaj"] = "Kullanıcı Adı veya Parola Hatalı !";
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}
