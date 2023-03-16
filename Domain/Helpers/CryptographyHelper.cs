using System.Security.Cryptography;
using System.Text;

namespace Domain.Helpers
{
    public static class CryptographyHelper
    {
        public static string HashMD5(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Data cannot be empty";
            }
            else
            {
                MD5 md5 = MD5.Create();
                Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(text);
                Byte[] encodedBytes = md5.ComputeHash(originalBytes);

                return Convert.ToHexString(encodedBytes);
            }
        }

        public static string HashMD5_2(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Data cannot be empty";
            }
            else
            {
                MD5 md5 = MD5.Create();
                Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(text);
                Byte[] encodedBytes = md5.ComputeHash(originalBytes);

                string passwordhash = BitConverter.ToString(encodedBytes).Replace("-", "").ToLower();
                return passwordhash;
            }

        }
    }
}
