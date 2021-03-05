using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HttpClientDemo.Enum
{
    /// <summary>
    /// 自定义系统编码
    /// </summary>
    public enum SystemCode
    {
        [Description("操作成功")]
        Success = 1,
        [Description("操作失败")]
        Fail = 0
    }
}
