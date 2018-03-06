using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string title, int pages, double longitude, double latitude)
        {
            Title = title;
            Pages = pages;
            Latitude = latitude;
            Longitude = longitude;
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        [Required]
        public Author Authors { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}