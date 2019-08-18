﻿using System.Collections.Generic;

namespace GraphQlDemo.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Message> Messages { get; set; }
    }
}
