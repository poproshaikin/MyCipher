namespace MyCipher
{
    public class CipheringService
    {
        public Algorithm CipheringAlgorithm { get; private set; }

        public void SetAlgorithm(Algorithm alg)
        {
            CipheringAlgorithm = alg;
        }

        public string Encrypt(string text)
        {
            return CipheringAlgorithm.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return CipheringAlgorithm.Decrypt(text);
        }
    }
}
