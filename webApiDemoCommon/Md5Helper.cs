using System.Security.Cryptography;
using System.Text;
namespace webApiDemoCommon
{
    public static class Md5Helper
    {
         public static string ToMd5(this string str){
        {
                MD5 md5 = new MD5CryptoServiceProvider( );
                byte[] output = md5.ComputeHash(Encoding.Default.GetBytes(str));
                string md5Str = BitConverter.ToString(output);
                return md5Str;
        }
    }
}