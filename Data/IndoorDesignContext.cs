using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndoorDesign.backend.application.dto;

namespace IndoorDesign.Data
{
    public class IndoorDesignContext : DbContext
    {
        public IndoorDesignContext (DbContextOptions<IndoorDesignContext> options)
            : base(options)
        {
        }

        public DbSet<IndoorDesign.backend.application.dto.MaterialTypeDto> MaterialTypeDto { get; set; } = default!;
    }
}
