using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class About : Form
  {
    public About()
    {
      InitializeComponent();
    }

    private void About_Load(object sender, EventArgs e)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
      string version = fileVersionInfo.ProductVersion;
      VersionLbl.Text = string.Format("Ver. {0}", version);
      copyrightLbl.Text = "yansaan © 2021";
    }

    private void YTlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      Process.Start(@"https://www.youtube.com/channel/UCsLGdzptbeGf8cgout9oNOw");

    private void KKlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      Process.Start(@"https://karyakarsa.com/yansaan");

    private void TrakteerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      Process.Start(@"https://trakteer.id/yansaan");

    private void SaweriaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      Process.Start(@"https://saweria.co/yansaan");

    private void patreonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
      Process.Start("https://patreon.com/yansaan_");
  }
}
