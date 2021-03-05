using HttpClientDemo.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {

            #region get返回字符串
            //string getUrl = "http://localhost:5000/api/user/getalllist";
            //string response = await HttpClientHelper.GetAsync(getUrl);
            //Console.WriteLine(response);
            #endregion

            #region get返回对象
            //string getUrl = "http://localhost:5000/api/user/getalllist";
            //var response = await HttpClientHelper.GetObjectAsync<ResultContent<List<UserDto>>> (getUrl);
            //Console.WriteLine(response);
            #endregion

            #region post返回字符串
            //string postUrl = "http://localhost:5000/api/user";
            //User user = new User
            //{
            //    LoginID = "testpost",
            //    Password = "123456",
            //    Name = "测试post请求",
            //    MobileNumber = "13823129834",
            //    EmailAddress = "sf34234@qq.com"
            //};
            //// 序列化对象
            //string json = JsonConvert.SerializeObject(user);
            //string response = await HttpClientHelper.PostAsyncJson(postUrl, json);
            //Console.WriteLine(response);
            #endregion

            #region post返回对象
            //string postUrl = "http://localhost:5000/api/user";
            //User user = new User
            //{
            //    LoginID = "testpost1",
            //    Password = "123456",
            //    Name = "测试post请求1",
            //    MobileNumber = "13823129834",
            //    EmailAddress = "sf34234@qq.com"
            //};
            //var response = await HttpClientHelper.PostObjectAsync<ResultContent<string>, User>(postUrl, user);
            #endregion

            #region put返回字符串
            //string putUrl = "http://localhost:5000/api/user";
            //User user = new User
            //{
            //    ID=Guid.Parse("EB7CC516-D7F3-4F68-BDF1-F9EDF7C5A713"),
            //    ClusterID=9,
            //    Password = "123456",
            //    Name = "测试post请求1修改",
            //    MobileNumber = "13323129834",
            //    EmailAddress = "sf34234@qq.com"
            //};
            //string json = JsonConvert.SerializeObject(user);
            //var response = await HttpClientHelper.PutAsync(putUrl, json);
            //Console.WriteLine(response);
            #endregion

            #region put返回对象
            //string putUrl = "http://localhost:5000/api/user";
            //User user = new User
            //{
            //    ID = Guid.Parse("EB7CC516-D7F3-4F68-BDF1-F9EDF7C5A713"),
            //    ClusterID = 9,
            //    Password = "12345678",
            //    Name = "测试post请求1修改123",
            //    MobileNumber = "13323129834",
            //    EmailAddress = "sf34234@qq.com"
            //};
            //var response = await HttpClientHelper.PutObjectAsync<ResultContent<string>, User>(putUrl, user);
            #endregion

            #region delete返回字符串
            //string deleteUrl = "http://localhost:5000/api/user?id=EB7CC516-D7F3-4F68-BDF1-F9EDF7C5A713";
            //string response = await HttpClientHelper.DeleteAsync(deleteUrl);
            //Console.WriteLine(response);
            #endregion

            #region delete返回字符串
            string deleteUrl = "http://localhost:5000/api/user?id=EB7CC516-D7F3-4F68-BDF1-F9EDF7C5A713";
            var response = await HttpClientHelper.DeleteObjectAsync<ResultContent<string>>(deleteUrl);
            #endregion

            Console.ReadKey();
            return 1;
        }
    }
}
