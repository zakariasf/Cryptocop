﻿using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Services.Interfaces;

namespace Cryptocop.Software.API.Services.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public void AddAddress(string email, AddressInputModel address)
        {
            _addressRepository.AddAddress(email, address);
        }

        public IEnumerable<AddressDto> GetAllAddresses(string email)
        {
            return _addressRepository.GetAllAddresses("Zakki");
        }

        public void DeleteAddress(string email, int addressId)
        {

            _addressRepository.DeleteAddress(email, addressId);
        }
    }
}