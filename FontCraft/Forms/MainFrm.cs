﻿using FontCraft.Util.Files;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class MainFrm : Form
  {
    public Graphics graph;

    MainFile mainFile;
    MainFile oldFile;

    Bitmap surface;
    PrivateFontCollection customFont;

    Bitmap vanila = new Bitmap(Properties.Resources.layout1);
    Bitmap faetful = new Bitmap(Properties.Resources.layout2);

    Timer changedValue = new Timer();
    string filesPath;
    public MainFrm()
    {
      InitializeComponent();

      if (!Directory.Exists(Util.ArrayFont.path)) Directory.CreateDirectory(Util.ArrayFont.path);

      previewPanel.BackgroundImageLayout = ImageLayout.None;

      filesPath = "";

      int pixelX = 0;
      int pixelY = 0;

      for (int i = 0; i < 256; i++)
      {
        Panel editChar = new Panel();
        previewPanel.Controls.Add(editChar);
        editChar.BackColor = Color.Transparent;
        //editChar.FlatStyle = FlatStyle.Popup;
        editChar.ForeColor = SystemColors.ButtonShadow;
        editChar.Location = new Point(pixelX, pixelY);
        editChar.Name = "char" + i.ToString();
        editChar.Size = new Size(32, 32);
        editChar.TabIndex = i;
        //editChar.UseVisualStyleBackColor = false;
        editChar.Click += new EventHandler((sender, e) => editCharClick(sender, e, editChar.TabIndex));

        pixelX += 32;
        if (pixelX >= 512)
        {
          pixelX = 0;
          pixelY += 32;
        }
      }

      mainFile = new CreateFile().InitFile();
      oldFile = new CreateFile().InitFile();
    }

    private void editCharClick(object sender, EventArgs e, int i)
    {
      if (Util.ArrayFont.arrayFont[i] == "")
        return;

      int chars = i;
      if (chars > 32) chars -= 8;

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;

      Chars c = mainFile.chars[chars];

      EditCharFrm edit = new EditCharFrm(chars, i, ComboFont.SelectedIndex - 1, myStyle, c.x, c.y, c.size);
      edit.font = ComboFont.Text;

      if (edit.ShowDialog() == DialogResult.OK)
      {
        mainFile.chars[chars].x = edit.potitionX;
        mainFile.chars[chars].y = edit.potitionY;
        mainFile.chars[chars].size = edit.size;

        changed();
      }
    }

    private void MainFrm_Load(object sender, EventArgs e)
    {
      ComboFont.Items.Add("Custom");
      foreach (FontFamily font in FontFamily.Families)
      {
        ComboFont.Items.Add(font.Name);
      }

      ComboFont.SelectedIndex = 1;
      oldFile.font_name = ComboFont.Text;
    }

    private void changed()
    {
      if (mainFile.bold == 1)
        BoldBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        BoldBtn.BackColor = SystemColors.Control;

      if (mainFile.italic == 1)
        ItalicBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        ItalicBtn.BackColor = SystemColors.Control;



      surface = new Bitmap(512, 512);
      surface.MakeTransparent();
      graph = Graphics.FromImage(surface);
      previewPanel.BackgroundImage = surface;


      Brush white = new SolidBrush(Color.White);

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;


      string[] fontI = Util.ArrayFont.arrayFont;
      int pixelX = 0;
      int pixelY = 0;
      int ind = 0;

      for (int i = 0; i < fontI.Length; i++)
      {


        Bitmap bmpchar = new Bitmap(32, 32);
        if (fontI[i] != "")
        {
          Font setFont = (ComboFont.Text.Contains("(")) ?
            new Font(customFont.Families[0], (float)mainFile.chars[ind].size, myStyle) :
            new Font(FontFamily.Families[ComboFont.SelectedIndex - 1], (float)mainFile.chars[ind].size, myStyle);

          Graphics grpChar = Graphics.FromImage(bmpchar);
          grpChar.DrawString(fontI[i], setFont, white, new PointF(mainFile.chars[ind].x, mainFile.chars[ind].y));

          ind += 1;
        }

        graph.DrawImage(bmpchar, new Point(pixelX, pixelY));

        pixelX += 32;
        if (pixelX >= 512)
        {
          pixelX = 0;
          pixelY += 32;
        }
      }
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFont = new OpenFileDialog())
      {
        openFont.Title = "Get Custom Font...";
        openFont.Filter = "TTF file|*.ttf";

        if (openFont.ShowDialog() == DialogResult.OK)
        {
          if (!Directory.Exists(Path.Combine(Util.ArrayFont.path, "font")))
            Directory.CreateDirectory(Path.Combine(Util.ArrayFont.path, "font"));

          File.Copy(openFont.FileName, Path.Combine(Util.ArrayFont.path, @"font\font.ttf"), true);
          customFont = new PrivateFontCollection();
          customFont.AddFontFile(Path.Combine(Util.ArrayFont.path, @"font\font.ttf"));

          ComboFont.Items.RemoveAt(0);
          ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
          ComboFont.SelectedIndex = 0;
        }
        else
          ComboFont.SelectedIndex = 1;
      }
    }

    private void SelectFont(object sender, EventArgs e)
    {
      if (ComboFont.SelectedIndex == 0 && ComboFont.Text == "Custom")
      {
        BrowseBtn_Click(sender, e);
        return;
      }

      mainFile.font_name = ComboFont.Text;
      if (ComboFont.SelectedIndex > -1)
        changed();
    }

    //int position;

    //private void MousesDown(object sender, MouseEventArgs e)
    //{
    //  position = e.X;
    //}

    //private void FontSizeLbl_MouseMove(object sender, MouseEventArgs e)
    //{
    //  if (e.Button == MouseButtons.Left)
    //  {
    //    int newFontSize = Int32.Parse(TxtFontSize.Text) + ((e.X - position) / 10);

    //    if (newFontSize > 0)
    //      TxtFontSize.Text = newFontSize.ToString();
    //    else
    //      TxtFontSize.Text = 1.ToString();

    //    changedValue.Start();
    //  }
    //}

    //private void SizeChanging(object sender, EventArgs e)
    //{
    //  changed();
    //  changedValue.Stop();
    //}

    //private void InputSize(object sender, KeyPressEventArgs e)
    //{
    //  e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    //  ((e.KeyChar != '.') || (e.KeyChar != '-'));
    //}

    //private void InputEnter(object sender, KeyEventArgs e)
    //{
    //  if (e.KeyValue == 13)
    //  {
    //    changed();
    //  }
    //}

    //private void InputPosition(object sender, KeyPressEventArgs e)
    //{
    //  e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'));
    //}

    //private void PaddingXMove(object sender, MouseEventArgs e)
    //{
    //  if (e.Button == MouseButtons.Left)
    //  {
    //    int newPadding = Int32.Parse(PaddingY.Text) + ((e.X - position) / 10);

    //    PaddingY.Text = newPadding.ToString();

    //    changedValue.Start();
    //  }
    //}

    //private void PaddingYMove(object sender, MouseEventArgs e)
    //{
    //  if (e.Button == MouseButtons.Left)
    //  {
    //    int newPadding = Int32.Parse(PaddingX.Text) + ((e.X - position) / 10);

    //    PaddingX.Text = newPadding.ToString();

    //    changedValue.Start();
    //  }
    //}

    private void BoldBtn_Click(object sender, EventArgs e)
    {
      mainFile.bold = (mainFile.bold == 0) ? 1 : 0;
      
      changed();
    }

    private void ItalicBtn_Click(object sender, EventArgs e)
    {
      mainFile.italic = (mainFile.italic == 0) ? 1 : 0;

      changed();
    }

    private void ExportBtn_Click(object sender, EventArgs e)
    {
      string tempPath = Path.Combine(Path.GetTempPath(), "font.png");
      surface.Save(tempPath, ImageFormat.Png);

      ExportFrm expfrm = new Forms.ExportFrm();
      expfrm.name = ComboFont.Text.Replace("(", "").Replace(")", "");
      expfrm.typefont = (ComboFont.SelectedIndex == 0) ? 1 : 0;

      expfrm.ShowDialog();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) =>
      new About().ShowDialog();

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) =>
      Application.Exit();

    private bool Saveing()
    {
      String old = JsonSerializer.Serialize(oldFile);
      String newFile = JsonSerializer.Serialize(mainFile);

      if (old == newFile) return true;
      DialogResult exit = MessageBox.Show("", "",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

      if (exit == DialogResult.Yes)
        return new Util.SaveProcess().Save(mainFile, filesPath);

      else if (exit == DialogResult.No)
        return true;

      return false;
    }

    private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Saveing())
      {
        if (File.Exists(Path.Combine(Util.ArrayFont.path, @"font\font.ttf")))
        {
          //customFont.Dispose();
          //customFont = null;
          File.Delete(Path.Combine(Util.ArrayFont.path, @"font\font.ttf"));
        }
      }
      else
        e.Cancel = true;
    }

    private void changeAllChar(object sender, EventArgs e)
    {
      int chars = 56;

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;

      Chars c = mainFile.chars[chars];

      EditCharFrm edit = new EditCharFrm(-1, 64, ComboFont.SelectedIndex - 1, myStyle, c.x, c.y, c.size);
      edit.font = ComboFont.Text;

      if (edit.ShowDialog() == DialogResult.OK)
      {
        foreach (Chars chari in mainFile.chars)
        {
          chari.x = edit.potitionX;
          chari.y = edit.potitionY;
          chari.size = edit.size;
        }

        changed();
      }
    }

    private void newToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (Saveing())
      {
        mainFile = new CreateFile().InitFile();
        oldFile = new CreateFile().InitFile();
        ComboFont.SelectedIndex = 1;
        filesPath = "";
        oldFile.font_name = ComboFont.Text;         

        if (customFont.Families.Length > 0)
        {
          ComboFont.Items.RemoveAt(0);
          ComboFont.Items.Insert(0, "Custom");

          customFont.Dispose();
          MessageBox.Show(customFont.Families.Length.ToString());
            File.Delete(Path.Combine(Util.ArrayFont.path, @"font\font.ttf"));
          }

        changed();
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e) =>
      newToolStripMenuItem1_Click(sender, e);

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Util.SaveProcess save = new Util.SaveProcess();

        save.Save(mainFile);

      filesPath = save.savePath;
      oldFile = mainFile;
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Saveing())
      {
        OpenFileDialog open = new OpenFileDialog();

        open.Title = "Open Packs...";
        open.Filter = "FontCraft Packs|*.fcps";

        if (open.ShowDialog() == DialogResult.OK)
        {
          if (customFont != null)
          {
            customFont.Dispose();
            MessageBox.Show(customFont.Families.Length.ToString());
          }

          Util.OpenProcess op = new Util.OpenProcess();
          MainFile main = op.Open(open.FileName);

          mainFile = main;
          oldFile = main;

          ComboFont.Items.RemoveAt(0);
          if (File.Exists(Path.Combine(Util.ArrayFont.path, @"font\font.ttf")))
          {
            customFont = new PrivateFontCollection();
            customFont.AddFontFile(Path.Combine(Util.ArrayFont.path, @"font\font.ttf"));

            ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
          }
          else
            ComboFont.Items.Insert(0, "Custom");

          ComboFont.Text = mainFile.font_name;
          filesPath = open.FileName;

          changed();
          customFont.Dispose();
          customFont = null;
        }
      }
    }

    private void OpenBtn_ButtonClick(object sender, EventArgs e) => openToolStripMenuItem_Click(sender, e);
  }
}
