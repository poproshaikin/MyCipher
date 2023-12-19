namespace MyCipher
{
    public class CHA : Algorithm, ILayoutSelectible
    {
        // random characters will be inserted, while for the original characters, their ASCII code will be taken and decremented by 2
        private string _currentLayout { get; set; }
        private int _origChar { get; } = 6;  // index of original symbol pattern (******с)

        string ILayoutSelectible.CurrentLayout
        {
            get { return _currentLayout; }
        }

        public void SetLayout(string layout)
        {
            switch (layout.ToUpper())
            {
                case "LAT":
                    _currentLayout = CharactersLat;
                    break;

                case "CYR":
                    _currentLayout = CharactersCyr;
                    break;

                default:
                    throw new Exception(" System error occured: Wrong layout type");
            }
        }

        public override string Encrypt(string text)
        {
            string encryptedText = "";
 
            int patternCount = text.Length;
            int letterIndex = 0;

            for (int i = 0; i <= patternCount * _origChar && letterIndex < text.Length; i++)
            {
                if (i % _origChar == 0 && i != 0)
                {
                    int asciiCode = text[letterIndex];
                    asciiCode -= 2;

                    encryptedText += (char)asciiCode;
                    letterIndex++;
                }
                else
                {
                    encryptedText += _currentLayout[random.Next(1, _currentLayout.Length)];
                }
            }

            return encryptedText;
        }

        public override string Decrypt(string text)
        {
            string decryptedText = "";

            int patternCount = text.Length;

            for (int i = _origChar; i < patternCount; i += _origChar)
            {
                int asciiCode = text[i];
                asciiCode += 2;

                decryptedText += (char)asciiCode;
            }

            return decryptedText;
        }
    }
}
