# graphql-demo
Simple demo for GraphQL mapping dynamic properties from a non-ORM source

## Example query:
```
{
  products(id: [1, 3, 5]) {
    id
    name
    description
    attributes {
      name
      values
    }
    messages {
      text
      sortOrder
    }
  }
}
```
