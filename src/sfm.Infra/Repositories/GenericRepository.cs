using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using sfm.Domain.Interfaces;
using sfm.Infra.Configurations;

namespace sfm.Infra.Repositories
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public GenericRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public void Add(T Object)
        {
            using var db = new Context(_OptionsBuilder);
            db.Set<T>().Add(Object);
            db.SaveChanges();
        }

        public void Delete(T Object)
        {
            using var db = new Context(_OptionsBuilder);
            db.Set<T>().Remove(Object);
            db.SaveChangesAsync();
        }

        public T GetEntityById(Guid Id)
        {
            using var db = new Context(_OptionsBuilder);
            var objeto = db.Set<T>().Find(Id);
            db.Database.CloseConnection();
            return objeto;
        }

        public List<T> List()
        {
            using var db = new Context(_OptionsBuilder);
            return db.Set<T>().AsNoTracking().ToList();
        }

        public void Update(T Object)
        {
            using var db = new Context(_OptionsBuilder);
            db.Set<T>().Update(Object);
            db.SaveChangesAsync();
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            // Free any other managed objects here.
            if (disposing) handle.Dispose();
            disposed = true;
        }

        ~GenericRepository()
        {
            Dispose(false);
        }
    }
}
