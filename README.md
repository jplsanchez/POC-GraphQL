# POC-GraphQL

Prof of concept for GraphQL in .net 6 using Hot Chocolate



## Example Queries

~~~
mutation addAuthor {
  addAuthor(input: {name: "J.R.R. Tolkien"}) {
    record {
      id
      name
    }
  }
}


mutation addBook {
  addBook(input: 
  {
    author: "J.R.R. Tolkien",
    title: "The Lord of the Rings"
  }) {
    record {
      id
      title
      author {
        name
      }
    }
  }
}


query get{
  books{
    title
    author {
      name
    }
  }
}
~~~