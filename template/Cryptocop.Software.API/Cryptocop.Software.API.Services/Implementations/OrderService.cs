﻿using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Services.Interfaces;

namespace Cryptocop.Software.API.Services.Implementations
{
    public class OrderService : IOrderService
    {
        public IEnumerable<OrderDto> GetOrders(string email)
        {
            throw new System.NotImplementedException();
        }

        public void CreateNewOrder(string email, OrderInputModel order)
        {
            throw new System.NotImplementedException();
        }
    }
}