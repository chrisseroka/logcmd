using System;
namespace LogCmd
{
	class ConsoleEx
	{
		public static void Write(string text, int width, ConsoleColor? textColor = null, ConsoleColor? bkgColor = null)
		{
			width = width == 0 ? 10 : width;
			Console.ForegroundColor = textColor == null ? Colors.DefaultText : textColor.Value;
			Console.BackgroundColor = bkgColor == null ? Colors.DefaultBackground : bkgColor.Value;

			Console.Write(text.PadRight(width, ' '));
			Console.ResetColor();
		}

		public static void WriteLine(string text, int width, ConsoleColor? textColor = null, ConsoleColor? bkgColor = null)
		{
			Write(text, width, textColor, bkgColor);
			Console.SetCursorPosition(0, Console.CursorTop + 1);
		}
	}

}
