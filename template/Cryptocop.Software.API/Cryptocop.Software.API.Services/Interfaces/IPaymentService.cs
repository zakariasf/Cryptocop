using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;

namespace Cryptocop.Software.API.Services.Interfaces
{
    public interface IPaymentService
    {
        void AddPaymentCard(string email, PaymentCardInputModel paymentCard);
        IEnumerable<PaymentCardDto> GetStoredPaymentCards(string email);
    }
}