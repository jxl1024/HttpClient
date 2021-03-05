using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientDemo.Entity
{
    public class UserDto : User
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
    }
}
