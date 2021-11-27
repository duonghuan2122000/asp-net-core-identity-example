using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.AspNetIdentity.HttpApi
{
    /// <summary>
    /// Thực thể quyền hạn
    /// </summary>
    /// created by: dbhuan 26/11/2021
    public class AppRole: IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
