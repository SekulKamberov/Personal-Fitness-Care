namespace PersonalFitnessCare.Server.Contracts
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
