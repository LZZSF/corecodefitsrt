using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDbServices
{

    /// <summary>
    /// 用户管理
    /// </summary>
    public class UserManagement : ModelBaseClassLib
    {

        /// <summary>
        /// 姓名
        /// </summary>
        [MaxLength(100)]
        [Required, Column("UserNmae")]
        public string UserNmae { get; set; }

        /// <summary>
        /// 登录编号
        /// </summary>
        [MaxLength(20)]
        [Required, Column("UserLoginCode")]
        [Unique]
        //[Unique]
        public string UserLoginCode { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [MaxLength(40)]
        [Required, Column("UserLoginPwd")]
        public string UserLoginPwd { get; set; }

        public virtual IList<RoleManagement> RoleManagements { get; set; }


    }
}
