using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp_1.Data.Models
{
	public class Category
	{
		public int ID { set; get; }
		public string Name { set; get; }
		public string Description { set; get; }
		public List<Videos> videos ID { set; get; }
	}
}
