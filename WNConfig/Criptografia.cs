using System.Security.Cryptography;
using System.Text;

namespace WNConfig
{
    public class Criptografia
    {
        public static string Criptografar(string valor, string chave)
        {
            try
            {
                using Aes aesAlg = Aes.Create();
                byte[] keyBytes = Encoding.UTF8.GetBytes(chave.PadRight(32).Substring(0, 32));
                aesAlg.Key = keyBytes;
                aesAlg.IV = new byte[16]; // Inicialização com zeros

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using MemoryStream msEncrypt = new();
                using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
                using (StreamWriter swEncrypt = new(csEncrypt))
                {
                    swEncrypt.Write(valor);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }

        public static string Descriptografar(string valor, string chave)
        {
            try
            {
                using Aes aesAlg = Aes.Create();
                byte[] keyBytes = Encoding.UTF8.GetBytes(chave.PadRight(32).Substring(0, 32));
                aesAlg.Key = keyBytes;
                aesAlg.IV = new byte[16]; // Inicialização com zeros

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using MemoryStream msDecrypt = new(Convert.FromBase64String(valor));
                using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
                using StreamReader srDecrypt = new(csDecrypt);
                return srDecrypt.ReadToEnd();
            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }

    }
}
