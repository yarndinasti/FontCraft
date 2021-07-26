
namespace FontCraft.Forms
{
  partial class MainFrm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.previewPanel = new System.Windows.Forms.Panel();
      this.BgPanel = new System.Windows.Forms.Panel();
      this.ExportBtn = new System.Windows.Forms.Button();
      this.BrowseBtn = new System.Windows.Forms.Button();
      this.FontSizeLbl = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.BaseFont = new System.Windows.Forms.ComboBox();
      this.ComboFont = new System.Windows.Forms.ComboBox();
      this.TxtFontSize = new System.Windows.Forms.TextBox();
      this.PaddingXLbl = new System.Windows.Forms.Label();
      this.PaddingY = new System.Windows.Forms.TextBox();
      this.PaddingX = new System.Windows.Forms.TextBox();
      this.PaddingYLbl = new System.Windows.Forms.Label();
      this.BoldBtn = new System.Windows.Forms.Button();
      this.ItalicBtn = new System.Windows.Forms.Button();
      this.AboutBtn = new System.Windows.Forms.Button();
      this.BgPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // previewPanel
      // 
      this.previewPanel.BackColor = System.Drawing.Color.Transparent;
      this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.previewPanel.Location = new System.Drawing.Point(0, 0);
      this.previewPanel.Name = "previewPanel";
      this.previewPanel.Size = new System.Drawing.Size(512, 512);
      this.previewPanel.TabIndex = 2;
      // 
      // BgPanel
      // 
      this.BgPanel.BackColor = System.Drawing.SystemColors.Control;
      this.BgPanel.BackgroundImage = global::FontCraft.Properties.Resources.background;
      this.BgPanel.Controls.Add(this.previewPanel);
      this.BgPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BgPanel.Location = new System.Drawing.Point(0, 73);
      this.BgPanel.Name = "BgPanel";
      this.BgPanel.Size = new System.Drawing.Size(512, 512);
      this.BgPanel.TabIndex = 3;
      // 
      // ExportBtn
      // 
      this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ExportBtn.Location = new System.Drawing.Point(453, 42);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(50, 23);
      this.ExportBtn.TabIndex = 3;
      this.ExportBtn.Text = "Export";
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // BrowseBtn
      // 
      this.BrowseBtn.Location = new System.Drawing.Point(186, 11);
      this.BrowseBtn.Name = "BrowseBtn";
      this.BrowseBtn.Size = new System.Drawing.Size(35, 23);
      this.BrowseBtn.TabIndex = 4;
      this.BrowseBtn.Text = "...";
      this.BrowseBtn.UseVisualStyleBackColor = true;
      this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // FontSizeLbl
      // 
      this.FontSizeLbl.AutoSize = true;
      this.FontSizeLbl.Cursor = System.Windows.Forms.Cursors.SizeWE;
      this.FontSizeLbl.Location = new System.Drawing.Point(12, 46);
      this.FontSizeLbl.Name = "FontSizeLbl";
      this.FontSizeLbl.Size = new System.Drawing.Size(27, 15);
      this.FontSizeLbl.TabIndex = 7;
      this.FontSizeLbl.Text = "Size";
      this.FontSizeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousesDown);
      this.FontSizeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FontSizeLbl_MouseMove);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(93, 46);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 15);
      this.label3.TabIndex = 9;
      this.label3.Text = "Base";
      // 
      // BaseFont
      // 
      this.BaseFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.BaseFont.FormattingEnabled = true;
      this.BaseFont.Location = new System.Drawing.Point(127, 42);
      this.BaseFont.Name = "BaseFont";
      this.BaseFont.Size = new System.Drawing.Size(93, 23);
      this.BaseFont.TabIndex = 10;
      this.BaseFont.SelectedIndexChanged += new System.EventHandler(this.BaseFont_SelectedIndexChanged);
      // 
      // ComboFont
      // 
      this.ComboFont.FormattingEnabled = true;
      this.ComboFont.Location = new System.Drawing.Point(12, 11);
      this.ComboFont.Name = "ComboFont";
      this.ComboFont.Size = new System.Drawing.Size(167, 23);
      this.ComboFont.TabIndex = 11;
      this.ComboFont.SelectedIndexChanged += new System.EventHandler(this.SelectFont);
      // 
      // TxtFontSize
      // 
      this.TxtFontSize.Location = new System.Drawing.Point(42, 42);
      this.TxtFontSize.Name = "TxtFontSize";
      this.TxtFontSize.Size = new System.Drawing.Size(42, 23);
      this.TxtFontSize.TabIndex = 12;
      this.TxtFontSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputEnter);
      this.TxtFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputSize);
      // 
      // PaddingXLbl
      // 
      this.PaddingXLbl.AutoSize = true;
      this.PaddingXLbl.Cursor = System.Windows.Forms.Cursors.SizeWE;
      this.PaddingXLbl.Location = new System.Drawing.Point(233, 15);
      this.PaddingXLbl.Name = "PaddingXLbl";
      this.PaddingXLbl.Size = new System.Drawing.Size(26, 15);
      this.PaddingXLbl.TabIndex = 13;
      this.PaddingXLbl.Text = "Top";
      this.PaddingXLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousesDown);
      this.PaddingXLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaddingXMove);
      // 
      // PaddingY
      // 
      this.PaddingY.Location = new System.Drawing.Point(266, 11);
      this.PaddingY.Name = "PaddingY";
      this.PaddingY.Size = new System.Drawing.Size(42, 23);
      this.PaddingY.TabIndex = 12;
      this.PaddingY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputEnter);
      this.PaddingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPosition);
      // 
      // PaddingX
      // 
      this.PaddingX.Location = new System.Drawing.Point(266, 42);
      this.PaddingX.Name = "PaddingX";
      this.PaddingX.Size = new System.Drawing.Size(42, 23);
      this.PaddingX.TabIndex = 12;
      this.PaddingX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputEnter);
      this.PaddingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPosition);
      // 
      // PaddingYLbl
      // 
      this.PaddingYLbl.AutoSize = true;
      this.PaddingYLbl.Cursor = System.Windows.Forms.Cursors.SizeWE;
      this.PaddingYLbl.Location = new System.Drawing.Point(233, 46);
      this.PaddingYLbl.Name = "PaddingYLbl";
      this.PaddingYLbl.Size = new System.Drawing.Size(27, 15);
      this.PaddingYLbl.TabIndex = 13;
      this.PaddingYLbl.Text = "Left";
      this.PaddingYLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousesDown);
      this.PaddingYLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaddingYMove);
      // 
      // BoldBtn
      // 
      this.BoldBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BoldBtn.Location = new System.Drawing.Point(317, 11);
      this.BoldBtn.Name = "BoldBtn";
      this.BoldBtn.Size = new System.Drawing.Size(27, 23);
      this.BoldBtn.TabIndex = 14;
      this.BoldBtn.Text = "B";
      this.BoldBtn.UseVisualStyleBackColor = true;
      this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
      // 
      // ItalicBtn
      // 
      this.ItalicBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
      this.ItalicBtn.Location = new System.Drawing.Point(317, 42);
      this.ItalicBtn.Name = "ItalicBtn";
      this.ItalicBtn.Size = new System.Drawing.Size(27, 23);
      this.ItalicBtn.TabIndex = 14;
      this.ItalicBtn.Text = "I";
      this.ItalicBtn.UseVisualStyleBackColor = true;
      this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
      // 
      // AboutBtn
      // 
      this.AboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.AboutBtn.Location = new System.Drawing.Point(453, 11);
      this.AboutBtn.Name = "AboutBtn";
      this.AboutBtn.Size = new System.Drawing.Size(50, 23);
      this.AboutBtn.TabIndex = 15;
      this.AboutBtn.Text = "About";
      this.AboutBtn.UseVisualStyleBackColor = true;
      // 
      // MainFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(515, 587);
      this.Controls.Add(this.AboutBtn);
      this.Controls.Add(this.ItalicBtn);
      this.Controls.Add(this.BoldBtn);
      this.Controls.Add(this.PaddingYLbl);
      this.Controls.Add(this.PaddingXLbl);
      this.Controls.Add(this.PaddingX);
      this.Controls.Add(this.PaddingY);
      this.Controls.Add(this.TxtFontSize);
      this.Controls.Add(this.ComboFont);
      this.Controls.Add(this.BgPanel);
      this.Controls.Add(this.BaseFont);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.FontSizeLbl);
      this.Controls.Add(this.BrowseBtn);
      this.Controls.Add(this.ExportBtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainFrm";
      this.Text = "Fontcraft";
      this.Load += new System.EventHandler(this.MainFrm_Load);
      this.BgPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel previewPanel;
    private System.Windows.Forms.Button ExportBtn;
    private System.Windows.Forms.Button BrowseBtn;
    private System.Windows.Forms.Label FontSizeLbl;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox BaseFont;
    private System.Windows.Forms.Panel BgPanel;
    private System.Windows.Forms.ComboBox ComboFont;
    private System.Windows.Forms.TextBox TxtFontSize;
    private System.Windows.Forms.Label PaddingXLbl;
    private System.Windows.Forms.TextBox PaddingY;
    private System.Windows.Forms.TextBox PaddingX;
    private System.Windows.Forms.Label PaddingYLbl;
    private System.Windows.Forms.Button BoldBtn;
    private System.Windows.Forms.Button ItalicBtn;
    private System.Windows.Forms.Button AboutBtn;
  }
}

