using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;

namespace Cryptocop.Software.API.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderDto> GetOrders(string email);
        void CreateNewOrder(string email, OrderInputModel order);
    }
}