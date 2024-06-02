using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.Interface
{
    public interface IGenericRepository<TEntit>
    {
        Task<TEntit> Create(TEntit entity);
        Task<TEntit> Update(TEntit entity);
        Task<TEntit> Delete(TEntit entity);
    }
}