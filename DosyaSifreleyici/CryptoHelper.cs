using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class CryptoHelper
{
    
    public static byte[] Encrypt(byte[] data, string password)
    {
        using (Aes aes = Aes.Create())
        {
            byte[] salt = GenerateRandomBytes(32);
            var key = new Rfc2898DeriveBytes(password, salt, 100000);

            aes.Key = key.GetBytes(32);
            aes.IV = key.GetBytes(16);
            aes.Mode = CipherMode.CBC;

            using (MemoryStream ms = new MemoryStream())
            {
                
                ms.Write(salt, 0, salt.Length);

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.Close();
                }

                return ms.ToArray();
            }
        }
    }

    public static byte[] Decrypt(byte[] encryptedData, string password)
    {
        using (Aes aes = Aes.Create())
        {
            byte[] salt = new byte[32];
            Array.Copy(encryptedData, 0, salt, 0, 32); // İlk 32 byte salt

            var key = new Rfc2898DeriveBytes(password, salt, 100000);

            aes.Key = key.GetBytes(32);
            aes.IV = key.GetBytes(16);
            aes.Mode = CipherMode.CBC;

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptedData, 32, encryptedData.Length - 32);
                    cs.Close();
                }

                return ms.ToArray();
            }
        }
    }

    private static byte[] GenerateRandomBytes(int length)
    {
        byte[] bytes = new byte[length];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(bytes);
        }
        return bytes;
    }
}
