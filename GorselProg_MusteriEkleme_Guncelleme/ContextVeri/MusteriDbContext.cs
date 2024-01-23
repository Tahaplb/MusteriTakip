using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgAraSınav.ContextVeri
{
    internal class MusteriDbContext:DbContext
    {
        public DbSet<Musteri> musteris { get ; set; }


    }
}
