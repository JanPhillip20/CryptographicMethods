using System;

namespace cryptographicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Decryption!");
            var text = LoadTextFile.loadSpecificTextFile();
            var clearText = BruteForce.decryptionHandler(text);
            Console.WriteLine("Decryption beended!");
            Console.WriteLine(clearText);
        }
    }
}