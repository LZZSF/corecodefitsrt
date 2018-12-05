using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDbServices
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class UniqueAttribute : ValidationAttribute
    {
        public override Boolean IsValid(Object value)
        {
            //校验数据库是否存在当前Key
            return true;
        }
    }
}
