namespace LogCmd
{
	class LogData
	{
		public string Text {get;set;}

		public LogData(string text)
		{
			this.Text = text;
		}

		public override string ToString()
		{
			return this.Text;
		}
	}

}

