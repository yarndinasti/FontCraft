using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.IO.Compression;
using FontCraft.Util.Files;

namespace FontCraft.Util
{
  public class OpenProcess
  {
    ClsEncryptDecryptFiles decryptFiles = new ClsEncryptDecryptFiles("fontcraftfile");
    public MainFile Open (string path)
    {
      if (!Directory.Exists(ArrayFont.pathTemp)) Directory.CreateDirectory(Path.Combine(ArrayFont.pathTemp, "file"));
      if (!Directory.Exists(Path.Combine(ArrayFont.path, "font"))) 
        Directory.CreateDirectory(Path.Combine(Path.Combine(ArrayFont.path, "font")));


      File.WriteAllBytes(Path.Combine(ArrayFont.pathTemp, "file.zip"), decryptFiles.Decryption(path));
      ZipFile.ExtractToDirectory(Path.Combine(ArrayFont.pathTemp, "file.zip"), Path.Combine(ArrayFont.pathTemp, "file"));

      string json = File.ReadAllText(Path.Combine(ArrayFont.pathTemp, @"file\config.json"));

      MainFile mainFile = JsonSerializer.Deserialize<MainFile>(json);

      if (File.Exists(Path.Combine(ArrayFont.pathTemp, @"file\font.ttf")))
        File.Copy(Path.Combine(ArrayFont.pathTemp, @"file\font.ttf"),
          Path.Combine(ArrayFont.path, @"font\font.ttf"), true);

      Directory.Delete(Path.Combine(ArrayFont.pathTemp, "file"), true);
      File.Delete(Path.Combine(ArrayFont.pathTemp, "file.zip"));

      return mainFile;
    }
  }
}
