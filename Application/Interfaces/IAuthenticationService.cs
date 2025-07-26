using Contract.AuthenticationModel.Request;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        string Authenticate(AuthenticationRequest request);
    }
}
