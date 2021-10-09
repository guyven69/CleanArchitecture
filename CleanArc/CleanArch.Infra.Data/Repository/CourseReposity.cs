﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseReposity : ICourseRepository
    {
        private readonly UniversityDbContext _ctx;

        public CourseReposity(UniversityDbContext universityDbContext)
        {
            this._ctx = universityDbContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
