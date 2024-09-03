namespace AMMA20240901.Auth
{
    public interface IJwtAuthenticationService
    {
        String Authenticate(string userName);
    }
}
