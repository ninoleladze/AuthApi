using AuthHm.Common;
using AuthHm.DTOs;

namespace AuthHm.Services.Auth
{
    public interface IAuthServices
    {
        Result<int> Register(RegisterDto req);
        Result<string> Login(LoginDto req);


    }
}
