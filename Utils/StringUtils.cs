using System.Text;

namespace ConfiguratorNewest.Utils
{
    public class StringUtils
    {
        public string Crypt(string str)
        {
            // Codifica a string em Base64
            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(str));

            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                int codePoint = (int)encoded[i];
                if (i % 2 == 0)
                {
                    codePoint += 2;
                }
                else
                {
                    codePoint -= 2;
                }

                encrypted.Append((char)codePoint);
            }

            return encrypted.ToString();
        }

        public string CryptKyocera(string str)
        {
            byte[] bytes = System.Text.Encoding.Default.GetBytes(str);

            // Converter os bytes para uma string Base64
            string base64String = Convert.ToBase64String(bytes);
            // Codifica a string em Base64
            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < base64String.Length; i++)
            {
                int codePoint = (int)base64String[i];
                if (i % 2 == 0)
                {
                    codePoint += 2;
                }
                else
                {
                    codePoint -= 2;
                }

                encrypted.Append((char)codePoint);
            }

            return base64String.ToString();
        }
    }
}
