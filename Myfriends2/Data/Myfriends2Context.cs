using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myfriends2.Models;

namespace Myfriends2.Data
{
    public class Myfriends2Context : DbContext
    {
        public Myfriends2Context (DbContextOptions<Myfriends2Context> options)
            : base(options)
        {
        }

        public DbSet<Myfriends2.Models.Friend> Friend { get; set; } = default!;
        public DbSet<Myfriends2.Models.Image> Image { get; set; } = default!;
    }
}
