namespace WebApplication10.TokenAuthentication
{
    public interface ITokenManager
    {
        bool Authenticate(string userName, string password);
        Token NewToken();
        bool VerifyToken(string token);
    }
}