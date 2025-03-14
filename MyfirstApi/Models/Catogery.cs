using System;
namespace MyfirstApi.Models
{
	public class Catogery
	{
		public int  Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public virtual List<Product> Products { get; set; }

	}
}

