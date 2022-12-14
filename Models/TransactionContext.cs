using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCrud.Models
{
    public class TransactionContext: DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
        { }
        public DbSet<TransactionModel> TransactionModels { get; set; }

    }
}
