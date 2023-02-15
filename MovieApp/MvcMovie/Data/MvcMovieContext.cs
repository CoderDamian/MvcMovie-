using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (OracleConfiguration.TnsAdmin is null)
            {
                OracleConfiguration.TnsAdmin = @"C:\Users\Fmla\Documents\OracleWallet\MyERP\";
                OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
            }
        }
    }
}
