using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TodoItem> TodoItemRepository { get; }

        void SaveChanges();
    }
}
