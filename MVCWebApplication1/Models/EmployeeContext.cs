﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWebApplication1.Models
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> employee { get; set; }
    }
}