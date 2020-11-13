using System.Collections.Generic;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Repositories.Contexts;
using Cryptocop.Software.API.Models.Entities;
using System.Linq;

namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {

        private readonly CryptocopDbContext _dbContext;

        public AddressRepository(CryptocopDbContext dbContext)

        {
            _dbContext = dbContext;
        }

        public void AddAddress(string email, AddressInputModel address)
        {
            var addressEntity = new Address
            {
                StreetName = address.StreetName,
                City = address.City,
                Country = address.Country,
                HouseNumber = address.HouseNumber,
                ZipCode = address.ZipCode

            };
            _dbContext.Addresses.Add(addressEntity);
            _dbContext.SaveChanges();
        }

       // public IEnumerable<AddressDto> GetAllAddresses(string email)
       // {
         //   return _dbContext.Addresses.Where(m => m.User.Email == email).Select(m => new AddressDto
           // {
             //   Id = m.Id,
               // StreetName = m.StreetName,
       //         HouseNumber = m.HouseNumber,
         //       ZipCode = m.ZipCode,
           //     Country = m.Country,
             //   City = m.City
           // });

        //}
        public IEnumerable<AddressDto> GetAllAddresses(string email)
        {
            var userID = (from user in _dbContext.Users
                          select user.Id).SingleOrDefault();

            var addresses = (from address in _dbContext.Addresses
                                 // where address.UserId == userID

                             select new AddressDto
                             {
                                 Id = address.Id,
                                 StreetName = address.StreetName,
                                 HouseNumber = address.HouseNumber,
                                 ZipCode = address.ZipCode,
                                 Country = address.Country,
                                 City = address.City
                             }).ToList();
            return addresses;
        }

        public void DeleteAddress(string email, int addressId)
        {
            var userID = (from user in _dbContext.Users
                          select user.Id).SingleOrDefault();
            var address = (from a in _dbContext.Addresses
                           where a.UserId == userID && a.Id == addressId
                           select a).SingleOrDefault();
            if (address != null)
            {
                _dbContext.Addresses.Remove(address);
                _dbContext.SaveChanges();
            }
        }
    }
}