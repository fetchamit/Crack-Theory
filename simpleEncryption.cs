
using System;
using System.Text;

public class HelloWorld
{
    private static readonly string Key = "mykey";
    public static void Main(string[] args)
    {
          // Simple key (can be any string, shorter is easier)
        Console.WriteLine ("Try programiz.pro");
        string originalText = "Hello, Test!";
        string encryptedText = SimpleEncrypt(originalText);
        string decryptedText = SimpleDecrypt(encryptedText);

        Console.WriteLine("Original: " + originalText);
        Console.WriteLine("Encrypted: " + encryptedText);
        Console.WriteLine("Decrypted: " + decryptedText);
    }
    // Simple encryption function
    public static string SimpleEncrypt(string text)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ Key[i % Key.Length]));
        }
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(result.ToString()));
    }

    // Simple decryption function
    public static string SimpleDecrypt(string encryptedText)
    {
        byte[] bytes = Convert.FromBase64String(encryptedText);
        string text = Encoding.UTF8.GetString(bytes);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ Key[i % Key.Length]));
        }
        return result.ToString();
    }
}

