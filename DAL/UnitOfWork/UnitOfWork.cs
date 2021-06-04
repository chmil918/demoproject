using DAL.EF;
using DAL.Repositories.Abstract;
using DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private GeoEntContext db;
        private TestRepository testRepository;
        private ReagentRepository reagentRepository;
        private WorkerRepository workerRepository;
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new GeoEntContext(options);
        }
        public ITestRepository Tests
        {
            get
            {
                if (testRepository == null)
                    testRepository = new TestRepository(db);
                return testRepository;
            }
        }
        public IReagentRepository Reagents
        {
            get
            {
                if (reagentRepository == null)
                    reagentRepository = new ReagentRepository(db);
                return reagentRepository;
            }
        }
        public IWorkerRepository Workers
        {
            get
            {
                if (workerRepository == null)
                    workerRepository = new WorkerRepository(db);
                return workerRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();

        }
    }
}
