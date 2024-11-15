using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSencilla.WebAPI.Models;

namespace ApiSencilla.WebAPI.Data
{
    public class ApiSencillaWebAPIContext : DbContext
    {
        public ApiSencillaWebAPIContext (DbContextOptions<ApiSencillaWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSencilla.WebAPI.Models.Book> Book { get; set; } = default!;
    }
}
