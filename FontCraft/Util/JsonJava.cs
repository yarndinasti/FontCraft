using System;
using System.Collections.Generic;
using System.Text;

namespace FontCraft.Util.JsonJava
{
  public class PackJavaEdition
  {
    public string description { get; set; }
    public int pack_format { get; set; }
  }

  public class FontHDJava
  {
    public string type { get; set; }
    public string file { get; set; }
  }
}
