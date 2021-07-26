using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace FontCraft.Forms
{
  public partial class ExportFrm : Form
  {
    public string name, fontPath;
    public int typefont;

    string javaPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
    string bedrockPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
      "Packages", "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

    string javaRP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft"
      , "resourcepacks");
    public ExportFrm()
    {
      InitializeComponent();
    }

    private void ExportFrm_Load(object sender, EventArgs e)
    {
      NameFont.Enabled = !CheckExisting.Checked;
      listBox1.Enabled = CheckExisting.Checked;

      MCtypeInstall.Items.Clear();
      MCtypeInstall.Items.Add("Java");
      MCtypeInstall.Items.Add("Bedrock");

      MCtypeInstall.SelectedIndex = 0;
      NameFont.Text = String.Format("{0}'s Font Pack", name);
    }

    private void MCtypeInstall_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (MCtypeInstall.Text)
      {
        case "Java":
          ExportBtn.Enabled = Directory.Exists(javaPath) && VersionPack.SelectedIndex > 0;
          ExistingGroup.Enabled = Directory.Exists(javaPath) &&
            Directory.GetDirectories(Path.Combine(javaPath, "resourcepacks")).Length > 0;
          LblNotif.Text = (!Directory.Exists(javaPath)) ? "Minecraft Java not installed" : "";
          HdFontCheck.Enabled = (typefont == 1) && VersionPack.SelectedIndex > 3;
          VersionPack.Enabled = Directory.Exists(javaPath);

          VersionPack.Items.Clear();
          VersionPack.Items.Add("Select Version...");
          VersionPack.Items.Add("1.6.1 - 1.8.9");
          VersionPack.Items.Add("1.9 – 1.10.2");
          VersionPack.Items.Add("1.11 – 1.12.2");
          VersionPack.Items.Add("1.13 – 1.14.4");
          VersionPack.Items.Add("1.15 – 1.16.1");
          VersionPack.Items.Add("1.16.2 – 1.16.5");
          VersionPack.Items.Add("1.17+");
          break;
        case "Bedrock":

          break;
      }
    }

    private void CheckExisting_CheckedChanged(object sender, EventArgs e)
    {
      NameFont.Enabled = !CheckExisting.Checked;
      listBox1.Enabled = CheckExisting.Checked;

      listBox1.Items.Clear();

      foreach (string rp in Directory.GetDirectories(Path.Combine(javaRP)))
      {
        listBox1.Items.Add(rp.Split(@"\")[rp.Split(@"\").Length - 1]);
      }
    }

    private void ExportBtn_Click(object sender, EventArgs e)
    {
      switch (MCtypeInstall.Text)
      {
        case "Java":
          if (CheckExisting.Checked == true)
          {
            ChangeFont();
            return;
          }
          CreateResourcePack();
          break;
        case "Bedrock":

          break;
      }
    }

    private void ChangeFont()
    {
      throw new NotImplementedException();
    }

    private void CreateResourcePack()
    {

      if (Directory.Exists(Path.Combine(javaRP, NameFont.Text)))
      {
        MessageBox.Show(String.Format("{0} are available, use existing resource pack!", NameFont.Text), "Texture Pack Exist",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      string fontImgPath = Path.Combine(javaRP, NameFont.Text, @"assets\minecraft\textures\font");
      Directory.CreateDirectory(fontImgPath);

      var pack = new Util.JsonJava.PackJavaEdition
      {
        description = "Genereted automatically by FontCraft",
        pack_format = VersionPack.SelectedIndex
      };

      File.WriteAllText(Path.Combine(javaRP, NameFont.Text, "pack.mcmeta"), JsonSerializer.Serialize(new { pack }));

      if (HdFontCheck.Checked == true)
      {
        var providers = new Util.JsonJava.FontHDJava { type = "ttf", file = "minecraft:font.ttf" };
        File.WriteAllText(Path.Combine(javaRP, NameFont.Text, @"\assets\minecraft\font\default.json"), 
          JsonSerializer.Serialize(new { providers }));

        File.Copy(fontPath, Path.Combine(javaRP, NameFont.Text, @"\assets\minecraft\font\font.ttf"));
      }
      else
        File.Copy(Path.Combine(Path.GetTempPath(), "font.png"), Path.Combine(fontImgPath, "ascii.png"));

      MessageBox.Show(String.Format("{0} generated as Resourse Pack", NameFont.Text), "Font Exported!",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      Close();
    }

    private void VersionPack_SelectedIndexChanged(object sender, EventArgs e)
    {
      ExportBtn.Enabled = Directory.Exists(javaPath) && VersionPack.SelectedIndex > 0;
      HdFontCheck.Enabled = (typefont == 1) && VersionPack.SelectedIndex > 3;
    }
  }
}
