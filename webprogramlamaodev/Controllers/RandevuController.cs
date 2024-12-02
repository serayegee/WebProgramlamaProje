﻿using Microsoft.AspNetCore.Mvc;
using webprogramlamaodev.Models;

namespace webprogramlamaodev.Controllers
{
	public class RandevuController : Controller
	{
		public IActionResult Index()
		{
            ViewData["Title"] = "Anasayfa";
            return View();
		}

		public IActionResult Create() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Randevu model)
		{
			if (ModelState.IsValid) 
			{
				return RedirectToAction("Index");
			}
			return View(model);
		}
	}
}
