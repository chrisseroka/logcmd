using System;

namespace LogCmd
{
	static class Colors
	{
		public static ConsoleColor DefaultText 
		{
			get {return ConsoleColor.White;}
		}

		public static ConsoleColor DefaultBackground 
		{
			get {return ConsoleColor.Black;}
		}

		public static ConsoleColor SelectedText 
		{
			get {return ConsoleColor.DarkGray;}
		}

		public static ConsoleColor SelectedTextBackground
		{
			get { return ConsoleColor.White;}
		}

		public static ConsoleColor PanelBackground 
		{
			get { return ConsoleColor.DarkGray;}
		}
	}

}
