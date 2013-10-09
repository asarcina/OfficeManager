using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManager.DAL
{
    public class UnitOfWork : IDisposable
    {
        private DataContext context = new DataContext();
        private bool disposed = false;
        #region repository entity
        
        private Repository<User> userRepository;
        private Repository<Login> loginRepository;
        
        #endregion

        public Repository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new Repository<User>(context);
                }
                return userRepository;
            }
        }

        public Repository<Login> LoginRepository
        {
            get
            {
                if (this.loginRepository == null)
                {
                    this.loginRepository = new Repository<Login>(context);
                }
                return loginRepository;
            }
        }


        
        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
