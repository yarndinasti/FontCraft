using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace FontCraft.Forms
{
  public partial class MainFrm : Form
  {
    public Graphics g;
    public Graphics graph;

    string fontPath;

    Boolean toggleBold = false;
    Boolean toggleItalic = false;

    Bitmap surface;
    Boolean faetfulSet = false;
    PrivateFontCollection customFont;

    Bitmap vanila = new Bitmap(Properties.Resources.layout1);
    Bitmap faetful = new Bitmap(Properties.Resources.layout2);

    Timer changedValue = new Timer();
    public MainFrm()
    {
      InitializeComponent();

      previewPanel.BackgroundImageLayout = ImageLayout.None;
      TxtFontSize.Text = "24";
      PaddingY.Text = "0";
      PaddingX.Text = "0";

      changedValue.Interval = 800;
      changedValue.Tick += new EventHandler(SizeChanging);
    }

    private void MainFrm_Load(object sender, EventArgs e)
    {
      BaseFont.Items.Add("Vanila");
      BaseFont.Items.Add("Faetful");

      ComboFont.Items.Add("Custom");
      foreach (FontFamily font in FontFamily.Families)
      {
        ComboFont.Items.Add(font.Name);
      }

      BaseFont.SelectedIndex = 0;
      ComboFont.SelectedIndex = 1;
    }

    private void changed()
    {
      surface = new Bitmap(512, 512);
      surface.MakeTransparent();
      graph = Graphics.FromImage(surface);
      previewPanel.BackgroundImage = surface;
      g = previewPanel.CreateGraphics();


      Brush white = new SolidBrush(Color.White);

      g.DrawImage(faetfulSet ? faetful : vanila, new Point(0, 0));
      graph.DrawImage(faetfulSet ? faetful : vanila, new Point(0, 0));

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (toggleBold == true && toggleItalic == false)
        myStyle = FontStyle.Bold;
      else if (toggleBold == false && toggleItalic == true)
        myStyle = FontStyle.Italic;
      else if (toggleBold == true && toggleItalic == true)
        myStyle = FontStyle.Bold & FontStyle.Italic;

      Font setFont = (ComboFont.Text.Contains("(")) ?
        new Font((FontFamily)customFont.Families[0], Int32.Parse(TxtFontSize.Text), myStyle) :
        new Font(FontFamily.Families[ComboFont.SelectedIndex - 1], Int32.Parse(TxtFontSize.Text), myStyle);

      string[] fontI = Util.ArrayFont.arrayFont;
      int pixelX = 0 + Int32.Parse(PaddingY.Text);
      int pixelY = 64 + Int32.Parse(PaddingX.Text);
      for (int i = 0; i < fontI.Length - 1; i++)
      {
        g.DrawString(fontI[i],setFont, white, new Point(pixelX, pixelY));
        graph.DrawString(fontI[i],setFont, white, new Point(pixelX, pixelY));

        pixelX += 32;
        if (pixelX >= 512 + Int32.Parse(PaddingY.Text))
        {
          pixelX = 0 + Int32.Parse(PaddingY.Text);
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
          fontPath = openFont.FileName;
          customFont = new PrivateFontCollection();
          customFont.AddFontFile(openFont.FileName);

          ComboFont.Items.RemoveAt(0);
          ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
          ComboFont.SelectedIndex = 0;
        }
        else
          ComboFont.SelectedIndex = 1;
      }
    }

    private void BaseFont_SelectedIndexChanged(object sender, EventArgs e)
    {
      faetfulSet = BaseFont.SelectedIndex == 1;

      if (ComboFont.SelectedIndex > -1)
        changed();
    }

    private void SelectFont(object sender, EventArgs e)
    {
      if (ComboFont.SelectedIndex == 0 && ComboFont.Text == "Custom")
      {
        BrowseBtn_Click(sender, e);
        return;
      }

      if (ComboFont.SelectedIndex > -1)
        changed();
    }

    int position;

    private void MousesDown(object sender, MouseEventArgs e)
    {
      position = e.X;
    }

    private void FontSizeLbl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        int newFontSize = Int32.Parse(TxtFontSize.Text) + ((e.X - position) / 10);

        if (newFontSize > 0)
          TxtFontSize.Text = newFontSize.ToString();
        else
          TxtFontSize.Text = 1.ToString();

        changedValue.Start();
      }
    }

    private void SizeChanging(object sender, EventArgs e)
    {
      changed();
      changedValue.Stop();
    }

    private void InputSize(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      ((e.KeyChar != '.') || (e.KeyChar != '-'));
    }

    private void InputEnter(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        changed();
      }
    }

    private void InputPosition(object sender, KeyPressEventArgs e)
    {
      e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'));
    }

    private void PaddingXMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        int newPadding = Int32.Parse(PaddingY.Text) + ((e.X - position) / 10);

        PaddingY.Text = newPadding.ToString();

        changedValue.Start();
      }
    }

    private void PaddingYMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        int newPadding = Int32.Parse(PaddingX.Text) + ((e.X - position) / 10);

        PaddingX.Text = newPadding.ToString();

        changedValue.Start();
      }
    }

    private void BoldBtn_Click(object sender, EventArgs e)
    {
      toggleBold = !toggleBold;
      if (toggleBold == true)
        BoldBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        BoldBtn.BackColor = SystemColors.Control;

        changed();
    }

    private void ItalicBtn_Click(object sender, EventArgs e)
    {
      toggleItalic = !toggleItalic;
      if (toggleItalic == true)
        ItalicBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        ItalicBtn.BackColor = SystemColors.Control;

      changed();
    }

    private void ExportBtn_Click(object sender, EventArgs e)
    {
      string tempPath = Path.Combine(Path.GetTempPath(), "font.png");
      surface.Save(tempPath, ImageFormat.Png);

      ExportFrm expfrm = new Forms.ExportFrm();
      expfrm.name = ComboFont.Text.Replace("(", "").Replace(")", "");
      expfrm.typefont = (ComboFont.SelectedIndex == 0) ? 1 : 0;
      expfrm.fontPath = fontPath;

      expfrm.ShowDialog();
    }
  }
}
