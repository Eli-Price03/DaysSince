using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysSinceWPF.Models
{
	public class Days
	{
		public string Title { get; set; }
		public DateOnly StartDate { get; set; }

		private int _dayssince;

		public int DaysSince
		{
			get { return _dayssince; }
			set { _dayssince = (DateTime.Now.Date - StartDate.ToDateTime(new TimeOnly(0,0))).Days; }
		}


		public Days(string title, DateOnly start)
		{
			Title = title;
			StartDate = start;
			DaysSince = 1;
		}
	}
}
