using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MyBlockchain
{
    internal class Ext
    {
        public static string GetHash(string prevHash, string timestamp, string data)
        {
            var inputBytes = Encoding.UTF8.GetBytes(prevHash + timestamp + data);
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
