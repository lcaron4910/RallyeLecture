using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PPE
{
    class Hash
    {
        public static string GetSha256FromString(string data)
        {
            var message = Encoding.ASCII.GetBytes(data); SHA256Managed hashString = new SHA256Managed(); string hex = "";
            var hashValue = hashString.ComputeHash(message); foreach (byte x in hashValue) { hex += String.Format("{0:x2}", x); } return hex;
        } 
    }
}
