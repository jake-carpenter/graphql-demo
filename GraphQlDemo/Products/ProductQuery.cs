using GraphQL.Types;
using GraphQlDemo.Products.Mappings;
using GraphQlDemo.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQlDemo.Products
{
    public class ProductQuery : ObjectGraphType
    {
        public const string ProductIdName = "id";
        public const string ProductQueryName = "products";

        public Func<string, IProductPropertyMapper> MapperFactory { get; }

        public ProductQuery(Func<string, IProductPropertyMapper> mapperFactory)
        {
            var idArg = new QueryArgument<ListGraphType<IdGraphType>> { Name = ProductIdName };

            Field<ListGraphType<ProductGraphType>>(
                name: ProductQueryName,
                resolve: Resolve,
                arguments: new QueryArguments(idArg));
            MapperFactory = mapperFactory;
        }

        private object Resolve(ResolveFieldContext<object> context)
        {
            var ids = context.GetArgument<List<int>>(ProductIdName);
            var products = GetProducts(ids);

            foreach (var field in context.SubFields)
            {
                var mapper = MapperFactory(field.Key);
                if (mapper == null)
                    continue;

                foreach (var product in products.Values)
                {
                    mapper.Map(product);
                }
            }

            return products.Values;
        }

        private Dictionary<int, Product> GetProducts(List<int> idList)
        {
            if (idList == null || idList.Count == 0)
                return ProductList.Products;

            return idList
                .Where(id => ProductList.Products.ContainsKey(id))
                .Select(id => ProductList.Products[id])
                .ToDictionary(x => x.Id);
        }
    }
}

