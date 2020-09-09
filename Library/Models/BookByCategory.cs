using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookByCategory
    {
        
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book book { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }


    }
}
