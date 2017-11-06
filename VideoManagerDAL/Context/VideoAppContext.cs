using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerDAL.Entities;

namespace VideoManagerDAL.Context
{
    class VideoAppContext : DbContext
    {
        static DbContextOptions<VideoAppContext> options =
            new DbContextOptionsBuilder<VideoAppContext>()
                        .UseInMemoryDatabase("TheDB")
                        .Options;

        
       // public VideoAppContext() : base(options)
       //{

      //}
       public DbSet<Video> Videos { get; set; }
       public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = tcp:ingvareasv.database.windows.net, 1433; Initial Catalog = VideoApp; Persist Security Info = False; User ID = ingvar; Password = Ademus.1234; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            }
            
        }
    }
}
