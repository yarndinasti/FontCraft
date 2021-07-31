using System.IO;
using System.IO.Compression;
using System.Text.Json;
using FontCraft.Util.Files;
using System.Windows.Forms;
using System;

namespace FontCraft.Util
{
  public class SaveProcess
  {
    ClsEncryptDecryptFiles decryptFiles = new ClsEncryptDecryptFiles("fontcraftfile");
    public string savePath = "";

    public bool Save(MainFile main, string path = "", string fontPath = "")
    {
      string locate = "";
      if (path == "")
      {
        SaveFileDialog save = new SaveFileDialog();
        save.Title = "Save as...";
        save.Filter = "FontCraft Packs|*.fcps";

        int count = 1;
        string nameFile = String.Format("Font Pack {0}.fcps", count);

        while (File.Exists(save.FileName))
          nameFile = String.Format("Font Pack {0}.fcps", count++);

        save.FileName = nameFile;

        if (save.ShowDialog() == DialogResult.OK)
          locate = save.FileName;
      }
      else
        locate = path;

      if (locate == "")
        return false;

      if (!Directory.Exists(Path.Combine(ArrayFont.pathTemp, "file"))) 
        Directory.CreateDirectory(Path.Combine(ArrayFont.pathTemp, "file"));

      string json = JsonSerializer.Serialize(main);
      File.WriteAllText(Path.Combine(ArrayFont.pathTemp, @"file\config.json"), json);
      if (fontPath != "")
        File.Copy(fontPath, Path.Combine(ArrayFont.pathTemp, @"file\font.ttf"));

      ZipFile.CreateFromDirectory(Path.Combine(ArrayFont.pathTemp, "file"), Path.Combine(ArrayFont.pathTemp, "file.zip"));
      File.WriteAllBytes(locate, decryptFiles.Encryption(Path.Combine(ArrayFont.pathTemp, "file.zip")));

      Directory.Delete(Path.Combine(ArrayFont.pathTemp, "file"), true);
      File.Delete(Path.Combine(ArrayFont.pathTemp, "file.zip"));

      savePath = locate;

      return true;
    }

    public void ExportToJava()
    {

    }

    public void ExportToBedrock()
    {

    }

    public void ExportFileJava()
    {

    }

    public void ExportFileBedrock()
    {

    }
  }
}
