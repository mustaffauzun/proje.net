﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product         
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Educator { get; set; }
        public double Price { get; set; }
        public string Time { get; set; }
        public int    Quota { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}