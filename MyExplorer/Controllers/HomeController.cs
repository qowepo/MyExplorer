using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyExplorer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MyExplorer.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(string path)
		{
			FileViewModel fileViewModel = new FileViewModel();
			try
			{
				// Путь существует в проводнике
				if (path != null && Directory.Exists(path))
				{
					FileSystemInfo fileSystemInfo = new DirectoryInfo(path);
					fileViewModel = GetFileViewModel(fileSystemInfo);
				}
				else
				{
					Console.WriteLine("Путь не существует в проводнике.");
				}
			}
			catch( Exception ex)
            {
				Console.WriteLine(ex.ToString());
            }

			ViewData["MyPath"] = path ?? "";
			return View(fileViewModel);
		}
				
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		static FileViewModel GetFileViewModel(FileSystemInfo fileSystemInfo)
		{
			FileViewModel fileViewModel = new FileViewModel();
			fileViewModel.Name = fileSystemInfo.Name;
			fileViewModel.Path = fileSystemInfo.FullName;
			fileViewModel.IsDirectory = fileSystemInfo is DirectoryInfo;

			// Подсчет веса для файла
			if (!fileViewModel.IsDirectory)
			{
				FileInfo fileInfo = (FileInfo)fileSystemInfo;				
				fileViewModel.Size = (double)fileInfo.Length / 1024;
				return fileViewModel;
			}

			// Подсчет веса для папки
			DirectoryInfo directory = (DirectoryInfo)fileSystemInfo;
			double directorySize = 0;

			foreach (FileSystemInfo childFileSystemInfo in directory.GetFileSystemInfos())
			{
				FileViewModel childFileViewModel = GetFileViewModel(childFileSystemInfo);
				fileViewModel.Children.Add(childFileViewModel);

				// Обновление веса папки на основе веса всех вложенных элементов
				directorySize += childFileViewModel.Size;
			}

			fileViewModel.Size = directorySize;
			return fileViewModel;
		}
	}

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
