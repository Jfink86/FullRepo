using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookShelf.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; } /*<---Key should always be an int---->*/
        public string Title { get; set; }
        public DateTime Publisheddate { get; set; }
        public string Description { get; set; }
        public string ISNB { get; set; }

        [ForeignKey ("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } /*<---navagation property--->*/
        
    }

}