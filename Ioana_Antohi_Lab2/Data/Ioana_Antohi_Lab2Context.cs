using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ioana_Antohi_Lab2.Models;

namespace Ioana_Antohi_Lab2.Data
{
    public class Ioana_Antohi_Lab2Context : DbContext
    {
        public Ioana_Antohi_Lab2Context (DbContextOptions<Ioana_Antohi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ioana_Antohi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ioana_Antohi_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Ioana_Antohi_Lab2.Models.Author> Author { get; set; }

        public DbSet<Ioana_Antohi_Lab2.Models.Category> Category { get; set; }

        public DbSet<Ioana_Antohi_Lab2.Models.Member> Member { get; set; }

        public DbSet<Ioana_Antohi_Lab2.Models.Borrowing> Borrowing { get; set; }

    }
}
