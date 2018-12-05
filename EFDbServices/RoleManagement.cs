using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDbServices
{

    /// <summary>
    /// 角色管理
    /// </summary>
    public class RoleManagement : ModelBaseClassLib
    {
        /// <summary>
        /// 角色编码
        /// </summary>
        [MaxLength(50)]
        [Required, Column("RoleCode")]
        [Unique]
        public string RoleCode { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(50)]
        [Required, Column("RoleName")]
        [Unique]
        public string RoleName { get; set; }
    }
}
