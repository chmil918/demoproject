using DAL.Repositories.Abstract;
using System;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository Tests { get; }
        IWorkerRepository Workers { get; }
        IReagentRepository Reagents { get; }
        void Save();
    }
}
