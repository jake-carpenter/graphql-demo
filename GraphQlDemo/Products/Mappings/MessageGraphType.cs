using GraphQL.Types;
using GraphQlDemo.Products.Models;

namespace GraphQlDemo.Products.Mappings
{
    public class MessageGraphType : ObjectGraphType<Message>
    {
        public MessageGraphType()
        {
            Field(x => x.Text).Description("Message text");
            Field(x => x.SortOrder).Description("Order to display among list of other messages.");
        }
    }
}
