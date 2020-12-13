using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp_1.Data.Models;

namespace TestWebApp_1.Data.Interfaces
{
	interface IAllVideos
	{
		IEnumerable<Videos> Videos { get; }
		IEnumerable<Videos> GetFavVideos { get; set; }
		Videos getObjectVideos(int VideoID);
	}
}