
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace mClipboard
{
	class Program
	{
        [STAThread]
		public static void Main(string[] args)
		{
            if (!Clipboard.ContainsText())
            {
                Console.WriteLine("No text in clipboard.");
                Console.ReadKey();
            }
            else
            {
                string clip = Clipboard.GetText();
                List<char> symbs = new List<char>(clip);
                int num = 0;
                foreach (char ch in clip)
                {
                    if (ch == '\"')
                    {
                        symbs.Insert(num + 1, '\"');
                        num++;
                    }
                    else
                    {
                        if (ch == '\n'&& num!=symbs.Count-1)
                        {
                            symbs.Insert(num + 1, '|');
                            num++;
                        }
                    }
                    num++;
                }
                symbs.Insert(0, '\"');
                symbs.Add('\"');
                symbs.Add(';');
                Clipboard.SetText(new string(symbs.ToArray()));
            }
		}
	}
}