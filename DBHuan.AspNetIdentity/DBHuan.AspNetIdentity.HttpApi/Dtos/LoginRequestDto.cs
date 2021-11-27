using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.AspNetIdentity.HttpApi
{
    /// <summary>
    /// Dto request login
    /// </summary>
    /// created by: dbhuan 26/11/2021
    public class LoginRequestDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
