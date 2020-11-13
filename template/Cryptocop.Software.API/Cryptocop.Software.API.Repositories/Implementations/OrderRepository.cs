﻿using System;
using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Repositories.Contexts;


namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {

        private readonly CryptocopDbContext _dbContext;

        public OrderRepository(CryptocopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<OrderDto> GetOrders(string email)
        {
            throw new NotImplementedException();
        }

        public OrderDto CreateNewOrder(string email, OrderInputModel order)
        {
            throw new NotImplementedException();
        }
    }
}