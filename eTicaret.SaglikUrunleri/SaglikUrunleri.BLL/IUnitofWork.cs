using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.BLL
{
    public interface IUnitofWork
    {
        void Commit();
    }
}
