using Cryptocop.Software.API.Models.Entities;
using Cryptocop.Software.API.Repositories.Interfaces;
using Cryptocop.Software.API.Repositories.Contexts;

namespace Cryptocop.Software.API.Repositories.Implementations
{
    public class TokenRepository : ITokenRepository
    {

        private readonly CryptocopDbContext _dbContext;

        public TokenRepository(CryptocopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public JwtToken CreateNewToken()
        {
            throw new System.NotImplementedException();
        }

        public bool IsTokenBlacklisted(int tokenId)
        {
            throw new System.NotImplementedException();
        }

        public void VoidToken(int tokenId)
        {
            throw new System.NotImplementedException();
        }
    }
}