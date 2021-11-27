using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.AspNetIdentity.HttpApi
{
    /// <summary>
    /// Thực thể user
    /// </summary>
    /// created by: dbhuan 26/11/2021
    public class AppUser: IdentityUser<Guid>
    {
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Họ và tên đệm
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
