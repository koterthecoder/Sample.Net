﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts
{
    public interface ITodoItemService
    {
        ITodoItemService Get(long id);
    }
}
