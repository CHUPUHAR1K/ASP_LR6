﻿using Microsoft.AspNetCore.Mvc;
using ASP_LR6.Models;
using System;
using ASP_LR6.Models;


namespace ASP_LR6.Controllers
{

        public class PizzaOrderController : Controller
        {
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public IActionResult ConfirmOrder(User user)
            {
                if (user.Age > 16)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            [HttpPost]
            public IActionResult ProcessOrder(Product[] products)
            {
                if (products == null || products.Length == 0)
                {
                    return RedirectToAction("Index", "Home");
                }

                try
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                    }

                    return View(products);
                }
                catch (Exception)
                {
                    return RedirectToAction("Error", "Home");
                }
            }
        }

}
