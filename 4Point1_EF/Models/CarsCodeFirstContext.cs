using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4Point1_EF.Models
{
    class CarsCodeFirstContext : DbContext
    {
        public CarsCodeFirstContext()
        {

        }

        public CarsCodeFirstContext(DbContextOptions<CarsCodeFirstContext> options) : base(options)
        {

        }

    }
}
