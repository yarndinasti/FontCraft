using System.IO;
using System.Text;

public class ClsEncryptDecryptFiles
{
  public ClsEncryptDecryptFiles(string _KEY)
  {
    KeyStr = _KEY;
  }

  private string KeyValue;
  public string KeyStr
  {
    get
    {
      return KeyValue;
    }
    set
    {
      KeyValue = value;
    }
  }

  public byte[] Encryption(string file)
  {
    byte[] input = File.ReadAllBytes(file);

    System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
    System.Security.Cryptography.SHA256 SHA256hash;
    SHA256hash = System.Security.Cryptography.SHA256.Create();

    // Try
    AES.Key = SHA256hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(KeyStr));
    AES.Mode = System.Security.Cryptography.CipherMode.ECB;
    System.Security.Cryptography.ICryptoTransform DESEncrypter = AES.CreateEncryptor();
    byte[] Buffer = input;
    return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length);
  }

  public byte[] Decryption(string file)
  {

    byte[] input = File.ReadAllBytes(file);

    System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
    System.Security.Cryptography.SHA256 SHA256hash;
    SHA256hash = System.Security.Cryptography.SHA256.Create();

    // Try
    AES.Key = SHA256hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(KeyStr));
    AES.Mode = System.Security.Cryptography.CipherMode.ECB;
    System.Security.Cryptography.ICryptoTransform DESDecrypter = AES.CreateDecryptor();
    byte[] Buffer = input;
    return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length);
  }
}
