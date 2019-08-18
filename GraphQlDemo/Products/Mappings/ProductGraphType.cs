using GraphQL.Types;
using GraphQlDemo.Products.Models;

namespace GraphQlDemo.Products.Mappings
{
    public class ProductGraphType : ObjectGraphType<Product>
    {
        public ProductGraphType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the product");
            Field(x => x.Name).Description("Name of the product");
            Field(x => x.Description).Description("Description of the product");
            Field(x => x.Attributes, type: typeof(ListGraphType<AttributeGraphType>)).Description("Name of the product");
            Field(x => x.Messages, type: typeof(ListGraphType<MessageGraphType>)).Description("Product messages.");
        }
    }
}
