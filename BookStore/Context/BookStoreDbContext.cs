using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Book_store.BookStore.Context
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
