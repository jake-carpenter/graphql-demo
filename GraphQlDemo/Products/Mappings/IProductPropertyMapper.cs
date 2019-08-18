using GraphQlDemo.Products.Models;

namespace GraphQlDemo.Products.Mappings
{
    public interface IProductPropertyMapper
    {
        Product Map(Product product);
        bool AppliesTo(string value);
    }
}

