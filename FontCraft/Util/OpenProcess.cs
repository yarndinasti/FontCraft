using FontCraft.Util.Files;
using System;
using System.IO;
using System.IO.Compression;
using System.Text.Json;

namespace FontCraft.Util
{
  public class OpenProcess
  {
    public string fontFile;

    ClsEncryptDecryptFiles decryptFiles = new ClsEncryptDecryptFiles("fontcraftfile");
    public MainFile Open(string path)
    {
      string fontDir = Path.Combine(Util.ArrayFont.path, "font");

      if (!Directory.Exists(ArrayFont.pathTemp)) Directory.CreateDirectory(Path.Combine(ArrayFont.pathTemp, "file"));
      if (!Directory.Exists(fontDir))
        Directory.CreateDirectory(fontDir);

      File.WriteAllBytes(Path.Combine(ArrayFont.pathTemp, "file.zip"), decryptFiles.Decryption(path));
      ZipFile.ExtractToDirectory(Path.Combine(ArrayFont.pathTemp, "file.zip"), Path.Combine(ArrayFont.pathTemp, "file"));

      string json = File.ReadAllText(Path.Combine(ArrayFont.pathTemp, @"file\config.json"));

      MainFile mainFile = JsonSerializer.Deserialize<MainFile>(json);

      if (File.Exists(Path.Combine(ArrayFont.pathTemp, @"file\font.ttf")))
      {
        int count = 0;
        string nameFont = String.Format("font{0}", count.ToString("000"));

        while (File.Exists(Path.Combine(fontDir, nameFont + ".ttf")))
          nameFont = String.Format("font{0}", count++.ToString("000"));

        fontFile = Path.Combine(fontDir, nameFont + ".ttf");
        File.Copy(Path.Combine(ArrayFont.pathTemp, @"file\font.ttf"), fontFile);
      }

      Directory.Delete(Path.Combine(ArrayFont.pathTemp, "file"), true);
      File.Delete(Path.Combine(ArrayFont.pathTemp, "file.zip"));

      return mainFile;
    }
  }
}
