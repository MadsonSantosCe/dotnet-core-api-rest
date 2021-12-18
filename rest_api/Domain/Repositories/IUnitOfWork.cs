using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

    }
}
