using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp_1.Data.Models;
using TestWebApp_1.Data.Interfaces;

namespace TestWebApp_1.Data.Mocks
{
	public class MockVideos : IAllVideos
	{
		private readonly IVideosCategory _categoryVideos = new MockCategory();
		public IEnumerable<Videos> Videos 
		{
			get 
			{
				return new List<Videos>
				{
					new Videos {Name = "FunnyCat", Image = "", IsFavourite = true, Category = _categoryVideos.AllCategories.First}
				};
			}
			set;
		}
		public IEnumerable<Videos> GetFavVideos { get; set; }
	}
}