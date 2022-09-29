using System.Security.Cryptography;

namespace my_issue;
public class Class1
{
    public static void ExampleMethod(byte[] rgbIV)
    {
        var aesCng  = new AesCng();
        aesCng.IV = rgbIV;
        aesCng.CreateEncryptor();
    }
}
