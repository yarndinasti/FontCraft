using System;
using System.Collections.Generic;

namespace FontCraft.Util.File
{
  public class MainFile
  {
    public FontType font_type { get; set; }
    public int bold { get; set; }
    public int italic { get; set; }
    public List<Chars> chars { get; set; }
  }

  public class FontType
  {
    public string name { get; set; }
    public string locate { get; set; }
  }

  public class Chars
  {
    public int x { get; set; }
    public int y { get; set; }
    public int size { get; set; }
  }

  public class CreateFile
  {
    public MainFile InitFile()
    {
      var fontType = new FontType
      {
        name = "",
        locate = ""
      };

      List<Chars> chars = new List<Chars>();
      for (int i = 0; i < 247; i++)
        chars.Add(new Chars { x = 0, y = 0, size = 20 });


      return new MainFile
      {
        font_type = fontType,
        bold = 0,
        italic = 0,
        chars = chars
      };
    }
  }
}
