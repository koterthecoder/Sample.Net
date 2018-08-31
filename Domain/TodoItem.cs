using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Domain
{
    public class TodoItem : IEntity
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public TodoItem(long accountId)
        {
            this.AccountId = accountId;
            this.Created = SystemTime.Current();
            this.Modified = SystemTime.Current();
        }

    }
}
