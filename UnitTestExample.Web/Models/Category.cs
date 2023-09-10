﻿using System.Collections;
using System.Collections.Generic;

namespace UnitTestExample.Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
