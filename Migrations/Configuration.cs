namespace mvctest.Migrations
{
    using mvctest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mvctest.Models.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(mvctest.Models.TestContext context)
        {
            Author author1 = new Author("Jane Austen", 20);
            Author author2 = new Author("Charles Dickens", 30);
            Author author3 = new Author("Miguel de Cervantes", 40);
            context.Authors.AddOrUpdate(x => x.Id,
            author1,
            author2,
            author3
            );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Title = "Pride and Prejudice",
                    Pages = 320,
                    Authors = author3,
                    Longitude = -172.083739,
                    Latitude = 65.423021
                },
                new Book()
                {
                    Title = "Northanger Abbey",
                    Pages = 330,
                    Authors = author2,
                    Longitude = -112.083739,
                    Latitude = 27.423021
                },
                new Book()
                {
                    Title = "David Copperfield",
                    Pages = 512,
                    Authors = author1,
                    Longitude = -122.083739,
                    Latitude = 37.423021
                },
                new Book()
                {
                    Title = "Don Quixote",
                    Pages = 633,
                    Authors = author1,
                    Longitude = -132.083739,
                    Latitude = 35.423021
                }
                );
        }
    }
}
