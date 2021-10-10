
namespace FontCraft.Forms
{
  partial class About
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.VersionLbl = new System.Windows.Forms.Label();
      this.YTlink = new System.Windows.Forms.LinkLabel();
      this.KKlink = new System.Windows.Forms.LinkLabel();
      this.TrakteerLink = new System.Windows.Forms.LinkLabel();
      this.SaweriaLink = new System.Windows.Forms.LinkLabel();
      this.copyrightLbl = new System.Windows.Forms.Label();
      this.patreonLink = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::FontCraft.Properties.Resources.icon_8;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(78, 75);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(96, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(152, 45);
      this.label1.TabIndex = 1;
      this.label1.Text = "FontCraft";
      // 
      // VersionLbl
      // 
      this.VersionLbl.AutoSize = true;
      this.VersionLbl.Location = new System.Drawing.Point(103, 54);
      this.VersionLbl.Name = "VersionLbl";
      this.VersionLbl.Size = new System.Drawing.Size(38, 15);
      this.VersionLbl.TabIndex = 2;
      this.VersionLbl.Text = "label2";
      // 
      // YTlink
      // 
      this.YTlink.AutoSize = true;
      this.YTlink.Location = new System.Drawing.Point(13, 108);
      this.YTlink.Name = "YTlink";
      this.YTlink.Size = new System.Drawing.Size(53, 15);
      this.YTlink.TabIndex = 3;
      this.YTlink.TabStop = true;
      this.YTlink.Text = "YouTube";
      this.YTlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YTlink_LinkClicked);
      // 
      // KKlink
      // 
      this.KKlink.AutoSize = true;
      this.KKlink.Location = new System.Drawing.Point(72, 108);
      this.KKlink.Name = "KKlink";
      this.KKlink.Size = new System.Drawing.Size(63, 15);
      this.KKlink.TabIndex = 4;
      this.KKlink.TabStop = true;
      this.KKlink.Text = "Karyakarsa";
      this.KKlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KKlink_LinkClicked);
      // 
      // TrakteerLink
      // 
      this.TrakteerLink.AutoSize = true;
      this.TrakteerLink.Location = new System.Drawing.Point(141, 108);
      this.TrakteerLink.Name = "TrakteerLink";
      this.TrakteerLink.Size = new System.Drawing.Size(48, 15);
      this.TrakteerLink.TabIndex = 5;
      this.TrakteerLink.TabStop = true;
      this.TrakteerLink.Text = "Trakteer";
      this.TrakteerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TrakteerLink_LinkClicked);
      // 
      // SaweriaLink
      // 
      this.SaweriaLink.AutoSize = true;
      this.SaweriaLink.Location = new System.Drawing.Point(195, 108);
      this.SaweriaLink.Name = "SaweriaLink";
      this.SaweriaLink.Size = new System.Drawing.Size(47, 15);
      this.SaweriaLink.TabIndex = 6;
      this.SaweriaLink.TabStop = true;
      this.SaweriaLink.Text = "Saweria";
      this.SaweriaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaweriaLink_LinkClicked);
      // 
      // copyrightLbl
      // 
      this.copyrightLbl.AutoSize = true;
      this.copyrightLbl.Location = new System.Drawing.Point(103, 72);
      this.copyrightLbl.Name = "copyrightLbl";
      this.copyrightLbl.Size = new System.Drawing.Size(35, 15);
      this.copyrightLbl.TabIndex = 7;
      this.copyrightLbl.Text = "Copy";
      // 
      // patreonLink
      // 
      this.patreonLink.AutoSize = true;
      this.patreonLink.Location = new System.Drawing.Point(103, 131);
      this.patreonLink.Name = "patreonLink";
      this.patreonLink.Size = new System.Drawing.Size(48, 15);
      this.patreonLink.TabIndex = 8;
      this.patreonLink.TabStop = true;
      this.patreonLink.Text = "Patreon";
      this.patreonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.patreonLink_LinkClicked);
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 159);
      this.Controls.Add(this.patreonLink);
      this.Controls.Add(this.copyrightLbl);
      this.Controls.Add(this.SaweriaLink);
      this.Controls.Add(this.TrakteerLink);
      this.Controls.Add(this.KKlink);
      this.Controls.Add(this.YTlink);
      this.Controls.Add(this.VersionLbl);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "About";
      this.ShowInTaskbar = false;
      this.Text = "About";
      this.Load += new System.EventHandler(this.About_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label VersionLbl;
    private System.Windows.Forms.LinkLabel YTlink;
    private System.Windows.Forms.LinkLabel KKlink;
    private System.Windows.Forms.LinkLabel TrakteerLink;
    private System.Windows.Forms.LinkLabel SaweriaLink;
    private System.Windows.Forms.Label copyrightLbl;
    private System.Windows.Forms.LinkLabel patreonLink;
  }
}