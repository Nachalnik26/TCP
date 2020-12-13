using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp_1.Data.Models;
using TestWebApp_1.Data.Interfaces;

namespace TestWebApp_1.Data.Mocks
{
	public class MockCategory : IVideosCategory
	{
		public IEnumerable<Category> AllCategories
		get {
			return new List<Category>
			{
				new Category {CategoryName = "1", desc = "123"},
				new Category {CategoryName = "2", desc = "456"},
				new Category { CategoryName = "3", desc = "789"}
			};
		}
	}
}