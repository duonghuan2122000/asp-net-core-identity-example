using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.AspNetIdentity.HttpApi
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequestDto request);

        Task<bool> Register(RegisterRequestDto request);
    }
}
