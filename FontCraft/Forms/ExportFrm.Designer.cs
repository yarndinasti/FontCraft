
namespace FontCraft.Forms
{
  partial class ExportFrm
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.VersionPack = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.HdFontCheck = new System.Windows.Forms.CheckBox();
      this.ExportBtn = new System.Windows.Forms.Button();
      this.LblNotif = new System.Windows.Forms.Label();
      this.NameFont = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ExistingGroup = new System.Windows.Forms.GroupBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.CheckExisting = new System.Windows.Forms.CheckBox();
      this.MCtypeInstall = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.ExistingGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(411, 450);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.VersionPack);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.HdFontCheck);
      this.tabPage1.Controls.Add(this.ExportBtn);
      this.tabPage1.Controls.Add(this.LblNotif);
      this.tabPage1.Controls.Add(this.NameFont);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.ExistingGroup);
      this.tabPage1.Controls.Add(this.MCtypeInstall);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(403, 422);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Add in the game";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // VersionPack
      // 
      this.VersionPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.VersionPack.FormattingEnabled = true;
      this.VersionPack.Location = new System.Drawing.Point(102, 342);
      this.VersionPack.Name = "VersionPack";
      this.VersionPack.Size = new System.Drawing.Size(271, 23);
      this.VersionPack.TabIndex = 9;
      this.VersionPack.SelectedIndexChanged += new System.EventHandler(this.VersionPack_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 346);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 15);
      this.label3.TabIndex = 8;
      this.label3.Text = "Version Pack";
      // 
      // HdFontCheck
      // 
      this.HdFontCheck.AutoSize = true;
      this.HdFontCheck.Location = new System.Drawing.Point(22, 371);
      this.HdFontCheck.Name = "HdFontCheck";
      this.HdFontCheck.Size = new System.Drawing.Size(175, 19);
      this.HdFontCheck.TabIndex = 7;
      this.HdFontCheck.Text = "Export as HD Font (Optifine)";
      this.HdFontCheck.UseVisualStyleBackColor = true;
      // 
      // ExportBtn
      // 
      this.ExportBtn.Location = new System.Drawing.Point(320, 391);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(75, 23);
      this.ExportBtn.TabIndex = 6;
      this.ExportBtn.Text = "Export";
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // LblNotif
      // 
      this.LblNotif.AutoSize = true;
      this.LblNotif.Location = new System.Drawing.Point(22, 47);
      this.LblNotif.Name = "LblNotif";
      this.LblNotif.Size = new System.Drawing.Size(38, 15);
      this.LblNotif.TabIndex = 5;
      this.LblNotif.Text = "label3";
      // 
      // NameFont
      // 
      this.NameFont.Location = new System.Drawing.Point(67, 313);
      this.NameFont.Name = "NameFont";
      this.NameFont.Size = new System.Drawing.Size(306, 23);
      this.NameFont.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 316);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Name";
      // 
      // ExistingGroup
      // 
      this.ExistingGroup.Controls.Add(this.listBox1);
      this.ExistingGroup.Controls.Add(this.CheckExisting);
      this.ExistingGroup.Location = new System.Drawing.Point(8, 68);
      this.ExistingGroup.Name = "ExistingGroup";
      this.ExistingGroup.Size = new System.Drawing.Size(387, 233);
      this.ExistingGroup.TabIndex = 2;
      this.ExistingGroup.TabStop = false;
      this.ExistingGroup.Text = "Add in Existing Resource Pack";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(9, 47);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(367, 169);
      this.listBox1.TabIndex = 1;
      // 
      // CheckExisting
      // 
      this.CheckExisting.AutoSize = true;
      this.CheckExisting.Location = new System.Drawing.Point(14, 22);
      this.CheckExisting.Name = "CheckExisting";
      this.CheckExisting.Size = new System.Drawing.Size(187, 19);
      this.CheckExisting.TabIndex = 0;
      this.CheckExisting.Text = "Save to Existing Resource Pack";
      this.CheckExisting.UseVisualStyleBackColor = true;
      this.CheckExisting.CheckedChanged += new System.EventHandler(this.CheckExisting_CheckedChanged);
      // 
      // MCtypeInstall
      // 
      this.MCtypeInstall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.MCtypeInstall.FormattingEnabled = true;
      this.MCtypeInstall.Location = new System.Drawing.Point(59, 17);
      this.MCtypeInstall.Name = "MCtypeInstall";
      this.MCtypeInstall.Size = new System.Drawing.Size(314, 23);
      this.MCtypeInstall.TabIndex = 1;
      this.MCtypeInstall.SelectedIndexChanged += new System.EventHandler(this.MCtypeInstall_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Type";
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(403, 422);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Export";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // ExportFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 450);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "ExportFrm";
      this.Text = "ExportFrm";
      this.Load += new System.EventHandler(this.ExportFrm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ExistingGroup.ResumeLayout(false);
      this.ExistingGroup.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox NameFont;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox ExistingGroup;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.CheckBox CheckExisting;
    private System.Windows.Forms.ComboBox MCtypeInstall;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button ExportBtn;
    private System.Windows.Forms.Label LblNotif;
    private System.Windows.Forms.CheckBox HdFontCheck;
    private System.Windows.Forms.ComboBox VersionPack;
    private System.Windows.Forms.Label label3;
  }
}