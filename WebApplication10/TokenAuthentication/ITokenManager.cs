using System.Security.Claims;

namespace WebApplication10.TokenAuthentication
{
    public interface ITokenManager
    {
        bool Authenticate(string userName, string password);
        string NewToken();
        ClaimsPrincipal VerifyToken(string token);
    }
}