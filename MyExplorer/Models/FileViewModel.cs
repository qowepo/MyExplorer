using System.Collections.Generic;

namespace MyExplorer.Models
{
	public class FileViewModel
	{
		public string Name { get; set; }
		public string Path { get; set; }
		public bool IsDirectory { get; set; }
		public double Size { get; set; }
		public List<FileViewModel> Children { get; set; }

		public FileViewModel()
		{
			Children = new List<FileViewModel>();
		}
	}
}
