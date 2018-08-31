using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Persistence
{
    public class TodoItemRepository : IRepository<TodoItem>
    {
        private readonly DomainContext _context;

        public TodoItemRepository(DomainContext context)
        {
            _context = context;
        }

        public TodoItem GetById(long id)
        {
            //return _context.TodoItems.Where(x => x.AccountId.Equals(id)).FirstOrDefault();
            return new TodoItem(id);
        }

        public void Add(TodoItem objectToAdd)
        {
            _context.TodoItems.Add(objectToAdd);
        }

        public void Update(TodoItem objectToUpdate)
        {
            _context.Entry(objectToUpdate).State = EntityState.Modified;
            _context.Entry(objectToUpdate).State = objectToUpdate.Id == 0 ? EntityState.Added : EntityState.Modified;
        }
    }
}
