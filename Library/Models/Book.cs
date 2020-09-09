using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [DataType(DataType.Text)]
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime PrintPubDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EbookPubDate { get; set; }
        public string Language { get; set; }
        public string PrintISBN { get; set; }
        public string EbookISBN { get; set; }
        public int Pages { get; set; }
        [DataType(DataType.Text)]
        public string LCSubjectHeadings { get; set; }
        public string LCCallNumber { get; set; }
        public string DeweyDecimalNumber { get; set; }
        public string BisacSubjectHeadings { get; set; }
        public string DocumentType { get; set; }

        public byte[] CoverPagePhoto { get; set; }
        [DataType(DataType.Text)]
        public string FileName { get; set; }
        /* */

    }
}
