﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        //Get : /cpntroller/
        public IActionResult Index()
        {
            //CourseViewModel model = _courseService.GetCourses();
            //return View(model);

            //after removing IEnumerable<Course> Courses {get;set;} from ViewModels
            return View(_courseService.GetCourses());
        }
    }
}
