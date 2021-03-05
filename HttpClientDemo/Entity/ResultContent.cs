using HttpClientDemo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientDemo.Entity
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultContent<T>
    {
        /// <summary>
        /// 返回结果编码 
        /// </summary>
        public SystemCode Code { get; set; }

        /// <summary>
        /// 返回结果内容
        /// 处理成功 返回Success 处理失败 返回错误内容
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 成功 返回T类型数据的json格式字符串 失败 默认未null
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 数据库总条数（分页获取时使用）
        /// </summary>
        public int Count { get; set; }

    }
}
