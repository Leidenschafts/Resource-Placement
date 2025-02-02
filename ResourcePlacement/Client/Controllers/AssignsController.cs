﻿using Client.Base.Controllers;
using Client.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using ResourcePlacement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    [Route("[controller]")]
    public class AssignsController : BaseController<JobEmployee, JobEmployeeRepository, string>
    {
        private readonly JobEmployeeRepository repository;
        public AssignsController(JobEmployeeRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        [HttpPost("assign")]
        public JsonResult Register(JobEmployee jobEmployee)
        {
            var result = repository.Register(jobEmployee);
            return Json(result);
        }

        [HttpGet("assign-form")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
