using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; // RNGCryptoServiceProvider
using System.Text;
using System.Threading.Tasks;

namespace Protect.Resources.Tools
{
  internal  class CryptConfig
    {
        public static byte[] GetKey(int size)
        {
            char[] ramdomChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();
            byte[] Ckey = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(Ckey);
            }
            return Ckey;
        }

        public static byte[] GetIV(int size)
        {
            char[] ramdomChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();
            byte[] Ckey = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(Ckey);
            }
            return Ckey;
        }

    }
}
