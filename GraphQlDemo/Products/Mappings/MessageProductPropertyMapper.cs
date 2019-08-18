using GraphQlDemo.Products.Models;
using System.Collections.Generic;

namespace GraphQlDemo.Products.Mappings
{
    public class MessageProductPropertyMapper : IProductPropertyMapper
    {
        private Dictionary<int, List<Message>> _messages;

        private Dictionary<int, List<Message>> Messages
        {
            get
            {
                if (_messages == null)
                    Messages = ProductList.Messages;

                return _messages;
            }

            set { _messages = value; }
        }

        public bool AppliesTo(string value) => value == "messages";

        public Product Map(Product product)
        {
            if (Messages.TryGetValue(product.Id, out var productMessages))
                product.Messages = productMessages;

            return product;
        }
    }
}

