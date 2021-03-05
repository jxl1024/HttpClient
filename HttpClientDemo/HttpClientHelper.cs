using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    public class HttpClientHelper
    {
        /// <summary>
        /// 发送get方法异步请求
        /// </summary>
        /// <param name="url">url请求地址</param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static async Task<string> GetAsync(string url, Dictionary<string, string> header = null)
        {
            using(HttpClient client=new HttpClient(new HttpClientHandler() { UseCookies = false }))
            {
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
       
        }

        /// <summary>
        /// 发送get异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <param name="url">url地址</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<T> GetObjectAsync<T>(string url, Dictionary<string, string> header = null)
        {
            string responseBody = await GetAsync(url,header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        /// <summary>
        /// 发送post异步请求
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="json">请求参数（json字符串）</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<string> PostAsyncJson(string url, string json, Dictionary<string, string> header = null)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new StringContent(json);
                // 设置请求格式
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                // 添加头部信息
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                // 调用Post方法
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        /// <summary>
        /// 发送post异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <typeparam name="T2">请求对象类型</typeparam>
        /// <param name="url">url地址</param>
        /// <param name="obj">请求对象数据</param>
        /// <param name="header">请求头部参数</param>
        /// <returns></returns>
        public static async Task<T> PostObjectAsync<T, T2>(string url, T2 obj,Dictionary<string,string> header=null)
        {
            String json = JsonConvert.SerializeObject(obj);
            string responseBody = await PostAsyncJson(url, json,header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        /// <summary>
        /// 发送put异步请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static async Task<string> PutAsync(string url, string json, Dictionary<string, string> header = null)
        {
            using(HttpClient client=new HttpClient(new HttpClientHandler() { UseCookies = false }))
            {
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                // 添加头部信息
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                HttpResponseMessage response = await client.PutAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        /// <summary>
        /// 发送put异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <typeparam name="T2">请求对象类型</typeparam>
        /// <param name="url">url地址</param>
        /// <param name="obj">请求对象数据</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<T> PutObjectAsync<T, T2>(string url, T2 obj, Dictionary<string, string> header = null)
        {
            String json = JsonConvert.SerializeObject(obj);
            string responseBody = await PutAsync(url, json, header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        /// <summary>
        /// 发送delete异步请求
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<string> DeleteAsync(string url, Dictionary<string, string> header = null)
        {
            using(HttpClient client=new HttpClient(new HttpClientHandler() { UseCookies = false }))
            {
                // 添加头部信息
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                HttpResponseMessage response = await client.DeleteAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        /// <summary>
        /// 发送delete异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <param name="url">url地址</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<T> DeleteObjectAsync<T>(string url, Dictionary<string, string> header = null)
        {
            string responseBody = await DeleteAsync(url,header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }
    }
}
