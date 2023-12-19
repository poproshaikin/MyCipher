using System;

namespace MyCipher
{
    public abstract class Algorithm
    {
        protected static string CharactersLat { get; } =
            @"qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM[];'\,./{}:|<>?";

        protected static string CharactersCyr { get; } =
            @"цукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮіїєґ/\[];'\,./{}:|<>?";
        
        
        protected Random random { get; } = new Random();
        
        public abstract string Encrypt(string text);
        public abstract string Decrypt(string text);
    }
}