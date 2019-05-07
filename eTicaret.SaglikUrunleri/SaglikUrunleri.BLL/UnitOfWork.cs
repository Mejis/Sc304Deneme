using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaglikUrunleri.DAL.Context;

namespace SaglikUrunleri.BLL
{
    public class UnitOfWork : IUnitofWork
    {
        private SaglikContext dbContext;
        public UnitOfWork(SaglikContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public SaglikContext DbContext
        {
            get { return dbContext; }
        }
        public void Commit()
        {
            try
            {
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
