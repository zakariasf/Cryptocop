using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;

namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class UserRepository: IUserRepository
    {
        public UserDto CreateUser(RegisterInputModel inputModel)
        {
            return new UserDto();
        }

        public UserDto AuthenticateUser(LoginInputModel loginInputModel)
        {
            return new UserDto();
        }
    }
}