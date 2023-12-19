namespace MyCipher
{
    public class NUM2 : Algorithm
    {
        private int[] _bufferCharacters { get; set; } = { 807, 729 };

        public override string Encrypt(string text)
        {
            string encryptedText = "";
            int letterIndex = 0;

            if (!IsDigitsOnly(text))
                return "Must be only digits!";
            if (text == "")
                return "null";

            for (int i = 0; i < text.Length * 6 && letterIndex < text.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    encryptedText += text[letterIndex];
                    letterIndex++;
                }
                else
                {
                    encryptedText += random.Next(0, 10);
                }
            }

            return encryptedText;
        }

        public override string Decrypt(string text)
        {
            string decryptedText = "";
            int letterIndex = 0;

            if (!IsDigitsOnly(text))
                return "Must be only digits!";
            if (text == "")
                return "null";

            for (int i = 5; i < text.Length; i += 5)
            {
                decryptedText += text[i];
            }

            return decryptedText;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach(char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}