using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Repositories.Contexts;

namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {

        private readonly CryptocopDbContext _dbContext;

        public UserRepository()
        {
        }

        public UserRepository(CryptocopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserDto AuthenticateUser(LoginInputModel loginInputModel)
        {
            throw new System.NotImplementedException();
        }

        public UserDto CreateUser(RegisterInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}