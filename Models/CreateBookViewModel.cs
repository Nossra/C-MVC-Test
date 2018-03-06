using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class CreateBookViewModel
    {
        public List<Author> Authors { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}