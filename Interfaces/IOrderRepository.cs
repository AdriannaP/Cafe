﻿using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
