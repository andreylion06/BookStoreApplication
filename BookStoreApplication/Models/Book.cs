using MainForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public Author Author { get; set; }
        public int PublisherID { get; set; }
        [ForeignKey("PublisherID")]
        public Publisher Publisher { get; set; }
        public int YearOfIssue { get; set; }
        public int NumberOfPages { get; set; }
        public int GenreID { get; set; }
        [ForeignKey("GenreID")]
        public Genre Genre { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public List<Basket> Basket { get; set; } = new List<Basket>();
    }
}