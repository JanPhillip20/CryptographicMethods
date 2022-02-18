using System.IO;

namespace cryptographicMethods
{
    public static class LoadTextFile
    {
        public static string loadSpecificTextFile()
        {
            return File.ReadAllText(@"/Users/jan/RiderProjects/cryptographicMethods/MoveCipherDecrypt/TestTextForDecryption.txt");
        }
    }
}