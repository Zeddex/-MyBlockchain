using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MyBlockchain
{
    internal class Ext
    {
        public static string GetHash(string inputData)
        {
            var inputBytes = Encoding.UTF8.GetBytes(inputData);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }

        public static string GetTimestamp()
        {
            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

            return timestamp.ToString();
        }
    }
}
