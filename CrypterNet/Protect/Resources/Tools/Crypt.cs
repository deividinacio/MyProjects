using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Protect.Resources.Tools
{
   internal class Crypt
    {
        public static byte[] AESEncript(byte[] shellcode, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = key;
                aes.IV = iv;

                using (var encriptor = aes.CreateEncryptor())
                {
                    using(var msEncShellcode = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(msEncShellcode, encriptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(shellcode, 0, shellcode.Length);
                            cryptoStream.FlushFinalBlock();
                            return msEncShellcode.ToArray();
                        }
                    }
                }
            }
        }


        public static byte[] AESDecript(byte[] shellcode, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = key;
                aes.IV = iv;

                using (var encriptor = aes.CreateDecryptor())
                {
                    using (var msEncShellcode = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(msEncShellcode, encriptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(shellcode, 0, shellcode.Length);
                            cryptoStream.FlushFinalBlock();
                            return msEncShellcode.ToArray();
                        }
                    }
                }
            }
        }


    }
}
