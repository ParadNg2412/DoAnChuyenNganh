using Microsoft.SqlServer.Management.Sdk.Sfc;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaberMart.Others
{
    public class Account
    {
        //private Account() { }

        //private static string PasswordEncryption(string password)
        //{
        //    //tính năng bảo mật cho việc đăng nhập
        //    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);//chuyển qua mảng kiểu byte từ một chuỗi
        //    byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
        //    //tạo ra bảng has(bảng băm) chứa các mảng byte
        //    //từ mật khẩu được mã hóa thành mảng băm

        //    string hasPass = "";

        //    foreach (byte item in hasData)
        //    {
        //        hasPass += item;
        //    }

        //    //tính năng mã hóa nâng cao bằng việc đảo ngược mật khẩu
        //    char[] arr = hasPass.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}

        //public static bool UpdatePasswordForAccount(string userName, string passWord, string newPassWord)
        //{

        //    string oldPass = PasswordEncryption(passWord);
        //    string newPass = PasswordEncryption(newPassWord);

        //    int result = DataProvider.ExecuteNonQuery("EXEC USP_UpdatePasswordForAccount @username , @pass , @newPass", new object[] { userName, oldPass, newPass });

        //    return result > 0;
        //}
    }
}
