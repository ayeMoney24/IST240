using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab7.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<bookContext>
    {
        protected override void Seed(bookContext context)
        {
            var author = new Author
            {
                biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var books = new List<Book>
            {
                new Book {
                    Author = author,
                    Description = "...",
                    ImageURl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA1160_.jpg",
                    isbn = "1491914319",
                    synopsis = "...",
                    title = "Knockout.js: Building Dynamic Client-Side Web Applications"
                },
                new Book {
                    Author = author,
                    Description = "...",
                    ImageURl = "http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
                    isbn = "1449319548",
                    synopsis = "...",
                    title = "20 Recipes for Programming PhoneGap: Cross-Platform Mobile Development for Android and iPhone"
                },
                new Book {
                    Author = author,
                    Description = "...",
                    ImageURl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
                    isbn = "1449309860",
                    synopsis = "...",
                    title = "20 Recipes for Programming MVC 3: Faster, Smarter Web Development"
                },
                new Book {
                    Author = author,
                    Description = "...",
                    ImageURl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
                    isbn = "1460954394",
                    synopsis = "...",
                    title = "Rapid Application Development With CakePHP"
                }
            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}