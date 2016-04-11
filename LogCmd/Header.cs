using System;
namespace LogCmd
{
	class Header
	{
		public void Render(int width)
		{
			var time = DateTime.Now;
			var part1 = String.Format("Console: {0} x {1}", Console.WindowWidth, Console.WindowHeight);
			var part2 = String.Format("Last render: {0}", time.ToString("HH:mm:ss"));
			var separator = width - part2.Length - 8;

			ConsoleEx.Write(
					String.Format("   {0}", part1),
					width - 30,
					Colors.DefaultText,
					Colors.PanelBackground);
			ConsoleEx.WriteLine(
					String.Format("{0}", part2),
					30,
					Colors.DefaultText,
					Colors.PanelBackground);
		}
	}

}
