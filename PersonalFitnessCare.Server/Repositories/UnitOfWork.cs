using System;
using PersonalFitnessCare.Server.Contracts;

namespace PersonalFitnessCare.Server.Repositories
{
    using System;
    using Contracts;
    using PersonalFitnessCare.Server.Models;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext context;//da smenq s moi DbContext

        public UnitOfWork(ApplicationDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required " +
                    "to use this repository.", nameof(context));
            }

            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}