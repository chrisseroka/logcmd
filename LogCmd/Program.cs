using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCmd
{
	class Program
	{
		static void Main(string[] args)
		{
			new Program().Run();

			Console.WriteLine("Press ESC to stop");
			Console.ReadKey();
		}

        void RenderHeader()
        {
			Console.WriteLine("------- header -----");
        }

        void RenderMain()
        {
			Console.WriteLine("------- main ------");
        }
         
        void RenderFooter()
        {
			Console.WriteLine("-------- footer -------");
        }

        void Render()
        {
			RenderHeader();
			RenderMain();
			RenderFooter();
        }

		void Run()
		{
			var data = new [] 
			{
				new LogData("Item 1"),
				new LogData("Item 2"),
				new LogData("Item 3")
			};
			var header = new Header();
			var listView = new ListView();
			listView.SetDataSource(data);

			var consoleWidth = Console.WindowWidth - 1;
			var consoleHeight = Console.WindowHeight;

			Console.SetCursorPosition(0, 0);
			header.Render(consoleWidth);
			listView.Render(consoleWidth, 3);

			while (true)
			{

				bool shouldRender = false;
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey(true);
					if (key.Key == ConsoleKey.J || key.Key == ConsoleKey.DownArrow)
					{
						listView.NavigateDown();
					}
					else if (key.Key == ConsoleKey.K || key.Key == ConsoleKey.UpArrow)
					{
						listView.NavigateUp();
					}
					else if (key.Key == ConsoleKey.Escape)
					{
						break;
					}
					shouldRender = true;
				}

				if (consoleWidth != Console.WindowWidth - 1|| consoleHeight != Console.WindowHeight)
				{
					consoleWidth = Console.WindowWidth - 1;
					consoleHeight = Console.WindowHeight;
					shouldRender = true;
				}

				if (shouldRender)
				{
					Console.SetCursorPosition(0, 0);
					header.Render(consoleWidth);
					listView.Render(consoleWidth, 3);
				}
			}
		}
	}
}
