using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace renov_AR.data
{
    public class renovARcontext : DbContext
    {
        public renovARcontext(DbContextOptions<renovARcontext> options) : base(options)
        {
        }
    }
}
