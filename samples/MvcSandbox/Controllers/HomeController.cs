// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace MvcSandbox.Controllers
{
    public class HomeController : Controller
    {
        [ModelBinder]
        public string Id { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [ProblemErrorPolicy]
        [HttpGet("/test")]
        public ActionResult<Person> PostString([FromQuery]int id)
        {
            return new Person { Id = 1 };
        }

        public class Person
        {
            public int Id { get; set; }
        }
    }
}
