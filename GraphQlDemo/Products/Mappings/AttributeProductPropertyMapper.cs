using GraphQlDemo.Products.Models;
using System.Collections.Generic;

namespace GraphQlDemo.Products.Mappings
{
    public class AttributeProductPropertyMapper : IProductPropertyMapper
    {
        private Dictionary<int, List<Attribute>> _attributes;

        private Dictionary<int, List<Attribute>> Attributes
        {
            get
            {
                if (_attributes == null)
                    Attributes = ProductList.Attributes;

                return _attributes;
            }

            set { _attributes = value; }
        }

        public bool AppliesTo(string value) => value == "attributes";

        public Product Map(Product product)
        {
            if (Attributes.TryGetValue(product.Id, out var productAttributes))
                product.Attributes = productAttributes;

            return product;
        }
    }
}

