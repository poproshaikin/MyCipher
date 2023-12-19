using Microsoft.VisualBasic;

namespace MyCipher
{
    public class D123 : Algorithm, ILayoutSelectible
    {
        private int _algPatternLength { get; set; } = 9;
        private string _algorithmFormula { get; set; } = "***c**c*c";
        private char _spaceChar { get; } = '~';   // will be inserted in place of a space
        private int _origCharsInPattern { get; set; } = 3;
        private string _endingCharacters { get; } = "!)@(#*"; // if any of the last unencrypted characters of the pattern contains these characters,
// the pattern is considered incomplete
        private string _currentLayout { get; set; }

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
            if (text == "")
                return "null";
            if (_currentLayout == null)
                return "Choose layout";
            
            string encryptedText = "";

            int textLength = text.Length; 
            int rest = textLength % _origCharsInPattern; 

            int patternsCount = 0;
            
            bool found = false;
            
            
            if (textLength <= _origCharsInPattern)
            {
                patternsCount = 1;
                found = true;
            }
            if (rest == 0 && !found)
            {
                patternsCount = textLength / _origCharsInPattern;
                found = true;
            }
            if (rest != 0 && !found)
            {
                patternsCount = (textLength - rest) / _origCharsInPattern;
                patternsCount++;
                
                found = true;
            }// these checks determine the number of patterns.

            int letterIndex = 0;
            
            
            for (int i = 0; i < patternsCount; i++)
            {
                for (int j = 0; j < _algPatternLength; j++)
                {
                    if (_algorithmFormula[j] == '*')
                    {
                        encryptedText += _currentLayout[random.Next(1, _currentLayout.Length)];
                    }
                    else if (_algorithmFormula[j] == 'c')
                    {
                        if (letterIndex < textLength)
                        {
                            if (text[letterIndex] == ' ')
                            {
                                encryptedText += _spaceChar;
                                letterIndex++;
                            }
                            else
                            {
                                encryptedText += text[letterIndex];
                                letterIndex++;
                            }
                        }
                        else
                        {
                            encryptedText += _endingCharacters[random.Next(1, _endingCharacters.Length)];
                        }
                    }
                }
            }
            
            return encryptedText;
        }

        public override string Decrypt(string text)
        {
            if (text == "")
                return "null";
            
            string decryptedText = "";
            int textLength = text.Length;
            
            int patternsCount = 0;
            int rest = textLength % _origCharsInPattern;

            bool found = false;

            if (rest == 0 && !found)
            {
                patternsCount = textLength / _algPatternLength;
                found = true;
            }

            if (rest != 0 && !found)
            {
                patternsCount = (textLength - rest) / _algPatternLength;
                patternsCount++;
                found = true;
            }

            int letterIndex = 0;
            
            for (int i = 0; i < patternsCount; i++)
            {
                for (int j = 0; j < _algPatternLength && letterIndex < textLength; j++)
                {
                    if (_algorithmFormula[j] == 'c')
                    {
                        if (text[letterIndex] == _spaceChar)
                        {
                            decryptedText += ' ';
                        }
                        else if (!_endingCharacters.Contains(text[letterIndex]))
                        {
                            decryptedText += text[letterIndex];
                        }
                    }
                    
                    letterIndex++;
                }
            }

            return decryptedText;

        }
    }
}