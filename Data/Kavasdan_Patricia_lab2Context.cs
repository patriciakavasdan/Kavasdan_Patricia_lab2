using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kavasdan_Patricia_lab2.Models;

namespace Kavasdan_Patricia_lab2.Data
{
    public class Kavasdan_Patricia_lab2Context : DbContext
    {
        public Kavasdan_Patricia_lab2Context (DbContextOptions<Kavasdan_Patricia_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Kavasdan_Patricia_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Kavasdan_Patricia_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Kavasdan_Patricia_lab2.Models.Author> Author { get; set; }

        public DbSet<Kavasdan_Patricia_lab2.Models.Category> Category { get; set; }

        public DbSet<Kavasdan_Patricia_lab2.Models.Member> Member { get; set; }

        public DbSet<Kavasdan_Patricia_lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
