using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Helpers;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Repositories.Contexts;
using CryptocopDbContext = Cryptocop.Software.API.Repositories.Contexts.CryptocopDbContext;

namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class PaymentRepository : IPaymentRepository
    {

        private readonly CryptocopDbContext _dbContext;

        public PaymentRepository(CryptocopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddPaymentCard(string email, PaymentCardInputModel paymentCard)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> GetStoredPaymentCards(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}