using System.Collections.Generic;

namespace GraphQlDemo.Products.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Values { get; set; }
    }
}
