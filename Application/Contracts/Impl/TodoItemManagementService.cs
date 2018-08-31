using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Impl
{
    public class TodoItemManagementService : ITodoItemManagementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TodoItemManagementService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException();


            _unitOfWork = unitOfWork;
        }

        public TodoItem GetByAccountId(long accountId)
        {
            if (accountId <= 0)
            {
                return null;
            }
            return _unitOfWork.TodoItemRepository.GetById(accountId);
        }

        public TodoItem Upsert(TodoItem item)
        {
            //if (item == null)
            //{
            //    throw new ArgumentNullException();
            //}

            //if (item.Id == 0)
            //{
            //    _unitOfWork.TodoItemRepository.Add(item);
            //}
            //else
            //{
            //    _unitOfWork.TodoItemRepository.Update(item);
            //}

            //_unitOfWork.SaveChanges();
            return item;
        }
    }
}
