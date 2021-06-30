using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Abstractions.Data
{
    public interface IAppContext : IUnitOfWorkCreator
    {
    }
}
