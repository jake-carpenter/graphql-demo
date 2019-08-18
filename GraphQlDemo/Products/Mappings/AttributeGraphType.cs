using GraphQL.Types;
using GraphQlDemo.Products.Models;

namespace GraphQlDemo.Products.Mappings
{
    public class AttributeGraphType : ObjectGraphType<Attribute>
    {
        public AttributeGraphType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the attribute");
            Field(x => x.Name).Description("name of the attribute");
            Field(x => x.Values, type: typeof(ListGraphType<StringGraphType>)).Description("Values for the attribute");
        }
    }
}
