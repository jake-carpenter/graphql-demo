using GraphQlDemo.Products.Models;
using System.Collections.Generic;

namespace GraphQlDemo.Products
{
    public static class ProductList
    {
        public static Dictionary<int, Product> Products = new Dictionary<int, Product>()
            {
                { 1, new Product { Id = 1, Name = "1", Description = "one" } },
                { 2, new Product { Id = 2, Name = "2", Description = "two" } },
                {3,  new Product { Id = 3, Name = "3", Description = "three" }},
                {4,  new Product { Id = 4, Name = "4", Description = "four" } },
                {5, new Product { Id = 5, Name = "5", Description = "five" }},
            };

        public static Dictionary<int, List<Message>> Messages = new Dictionary<int, List<Message>>
            {
                {
                    1, new List<Message>
                    {
                        new Message { Text = "Message 1", SortOrder = 1},
                        new Message { Text = "Message 50", SortOrder = 2}
                    }
                },
                {
                    2, new List<Message>
                    {
                        new Message { Text = "Message 30", SortOrder = 2},
                        new Message { Text = "Message 11", SortOrder = 1}
                    }
                },
                {
                    3, new List<Message>
                    {
                        new Message { Text = "Message 99", SortOrder = 2},
                        new Message { Text = "Message 21", SortOrder = 1}
                    }
                },
                {
                    4, new List<Message>
                    {
                    }
                },
                {
                    5, new List<Message>
                    {
                        new Message { Text = "Message 72", SortOrder = 2},
                        new Message { Text = "Message 56", SortOrder = 1}
                    }
                }
            };

        public static Dictionary<int, List<Attribute>> Attributes = new Dictionary<int, List<Attribute>>
            {
                {
                    1, new List<Attribute>
                    {
                        new Attribute {Id = 1, Name = "Size", Values = new List<string> { "1L" } },
                    }
                },
                {
                    2, new List<Attribute>
                    {
                        new Attribute {Id = 2, Name = "Active Ingredient", Values = new List<string> { "sodium chloride" } },
                        new Attribute {Id = 3, Name = "Size", Values = new List<string> { "250mL" } },
                    }
                },
                {
                    3, new List<Attribute>
                    {
                        new Attribute {Id = 4, Name = "Species", Values = new List<string> { "canine", "feline" } },
                        new Attribute {Id = 5, Name = "Size", Values = new List<string> { "250mL" } },
                    }
                },
                {
                    4, new List<Attribute>
                    {
                        new Attribute {Id = 6, Name = "Size", Values = new List<string> { "B100" } },
                    }
                },
                {
                    5, new List<Attribute>
                    {
                        new Attribute {Id = 7, Name = "Administration", Values = new List<string> { "oral" } },
                        new Attribute {Id = 8, Name = "Size", Values = new List<string> { "1L" } },
                    }
                },
            };
    }
}

