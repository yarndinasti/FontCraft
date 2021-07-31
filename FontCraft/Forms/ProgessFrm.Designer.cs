
namespace FontCraft.Forms
{
  partial class ProgessFrm
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
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.ProgessLbl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 63);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(277, 23);
      this.progressBar1.TabIndex = 0;
      // 
      // ProgessLbl
      // 
      this.ProgessLbl.AutoSize = true;
      this.ProgessLbl.Location = new System.Drawing.Point(12, 23);
      this.ProgessLbl.Name = "ProgessLbl";
      this.ProgessLbl.Size = new System.Drawing.Size(38, 15);
      this.ProgessLbl.TabIndex = 1;
      this.ProgessLbl.Text = "label1";
      // 
      // ProgessFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(301, 98);
      this.Controls.Add(this.ProgessLbl);
      this.Controls.Add(this.progressBar1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ProgessFrm";
      this.Text = "ProgessFrm";
      this.Load += new System.EventHandler(this.ProgessFrm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label ProgessLbl;
  }
}