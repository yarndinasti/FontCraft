using System.IO;
using System.IO.Compression;
using System.Text.Json;
using FontCraft.Util.Files;
using System.Windows.Forms;

namespace FontCraft.Util
{
  public class SaveProcess
  {
    ClsEncryptDecryptFiles decryptFiles = new ClsEncryptDecryptFiles("fontcraftfile");
    public string savePath = "";

    public bool Save(MainFile main, string path = "")
    {
      string locate = "";
      if (path == "")
      {
        SaveFileDialog save = new SaveFileDialog();
        save.Title = "Save as...";
        save.DefaultExt = "Pack";
        save.Filter = "FontCraft Packs|*.fcps";

        if (save.ShowDialog() == DialogResult.OK)
          locate = save.FileName;
      }
      else
        locate = path;

      if (locate == "")
        return false;

      if (!Directory.Exists(ArrayFont.pathTemp)) Directory.CreateDirectory(Path.Combine(ArrayFont.pathTemp, "file"));

      string json = JsonSerializer.Serialize(main);
      File.WriteAllText(Path.Combine(ArrayFont.pathTemp, @"file\config.json"), json);
      if (File.Exists(Path.Combine(ArrayFont.path, @"font\font.ttf")))
        File.Copy(Path.Combine(ArrayFont.path, @"font\font.ttf"),
          Path.Combine(ArrayFont.pathTemp, @"file\font.ttf"));

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
