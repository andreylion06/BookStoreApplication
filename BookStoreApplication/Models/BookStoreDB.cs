using MainForm.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Models
{
    public class BookStoreDB : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public BookStoreDB() : base("DBConnectionString") { }
    }
}
