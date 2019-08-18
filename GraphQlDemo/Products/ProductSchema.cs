using GraphQL;
using GraphQL.Types;

namespace GraphQlDemo.Products
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IDependencyResolver resolver) : base(resolver)
        {
             Query = resolver.Resolve<ProductQuery>();
        }
    }
}
