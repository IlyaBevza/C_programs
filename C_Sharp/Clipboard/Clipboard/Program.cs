
using System;
using System.Windows.Forms;

namespace mClipboard
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string clip=Clipboard.GetText();
			
			Console.WriteLine("{0}",clip);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}