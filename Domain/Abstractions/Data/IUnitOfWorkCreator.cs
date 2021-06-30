using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions.Data
{
    public interface IUnitOfWorkCreator
    {
        IUnitOfWork ICreateUnitOfWork();
    }
}
