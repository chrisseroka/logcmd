using System.Collections.Generic;
using System.Linq;

namespace LogCmd
{
	class ListView 
	{
        IEnumerable<LogData> DataSource { get; set; }
        LogData selectedItem;
        int selectedItemIndex = -1;

		public void SetDataSource(IEnumerable<LogData> dataSource)
		{
			this.DataSource = dataSource;
			if (this.DataSource.Any())
			{
				this.selectedItem = this.DataSource.First();
				this.selectedItemIndex = 0;
			}
		}

        void RenderItem(LogData item, int width)
        {
			ConsoleEx.WriteLine(
					item.ToString(),
					width,
					item == this.selectedItem ? Colors.SelectedText : Colors.DefaultText,
					item == this.selectedItem ? Colors.SelectedTextBackground : Colors.DefaultBackground);
        }
        
		public void Render(int width, int height)
		{
			foreach(var item in this.DataSource)
			{
				this.RenderItem(item, width);
			}
		}

		public void NavigateUp()
		{
			if (this.selectedItemIndex > 0)
			{
				this.selectedItemIndex--;
				this.selectedItem = this.DataSource.ElementAtOrDefault(this.selectedItemIndex);
			}
		}

		public void NavigateDown()
		{
			if (this.selectedItemIndex < (this.DataSource.Count() - 1))
			{
				this.selectedItemIndex++;
				this.selectedItem = this.DataSource.ElementAtOrDefault(this.selectedItemIndex);
			}
		}
	}

}
