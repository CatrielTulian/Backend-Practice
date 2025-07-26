using Application.Interfaces;
using Contract.AuthenticationModel.Helpers;
using Contract.AuthenticationModel.Request;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.ThirdPartyServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly AuthenticationServiceOptions _options;

        public AuthenticationService(IPersonRepository personRepository, IOptions<AuthenticationServiceOptions> options)
        {
            _personRepository = personRepository;
            _options = options.Value;
        }

        private Persons? ValidateUser(AuthenticationRequest authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.User) || string.IsNullOrEmpty(authenticationRequest.Password)) ;
            return null;

            var persons = _personRepository.GetAllPersons();
            var user = persons.FirstOrDefault(x => x.User.Equals(authenticationRequest.User) && x.Password.Equals(authenticationRequest.Password));

            return user;
        }

        public string Authenticate(AuthenticationRequest authenticationRequest)
        {
            var user = ValidateUser(authenticationRequest);

            if (user == null)
            {
                throw new Exception("User authentication failed");
            }

            var securiryPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_options.SecretKey));
            var credemtials = new SigningCredentials(securiryPassword, SecurityAlgorithms.HmacSha256);

            var claimsForToken = new List<Claim>();
            {
                new Claim("sub", user.Id.ToString());
            }
            ;

            var jwtSecurityToken = new JwtSecurityToken(
                _options.Issuer,
                _options.Audience,
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                credemtials);
            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return tokenToReturn.ToString();
        }
    }
}
