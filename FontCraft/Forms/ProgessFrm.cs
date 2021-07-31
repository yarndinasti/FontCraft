using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class ProgessFrm : Form
  {
    public ProgessFrm()
    {
      InitializeComponent();
    }

    public void label(string lbl)
    {
      ProgessLbl.Text = lbl;
    }

    public void progess(int p)
    {
      progressBar1.Value = p;

      if (progressBar1.Value == progressBar1.Maximum)
        DialogResult = DialogResult.OK;
    }

    private void ProgessFrm_Load(object sender, EventArgs e)
    {
      progressBar1.Value = 0;
    }
  }
}
