using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class Author
    {
        public Author()
        {

        }

        public Author(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [Key]
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}