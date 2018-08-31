using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DomainContext _context;

        public IRepository<TodoItem> TodoItemRepository { get; }

        public UnitOfWork(DomainContext context, IRepository<TodoItem> todoItemRepository)
        {
            _context = context;
            TodoItemRepository = todoItemRepository;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
