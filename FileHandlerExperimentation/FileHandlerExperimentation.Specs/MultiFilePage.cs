using OpenQA.Selenium;
using SpecBind.Pages;

namespace FileHandlerExperimentation.Specs
{
	[PageNavigation("/Home/MultiUpload")]
	public class MultiFilePage
	{
		[ElementLocator(Id = "file1")]
		public IWebElement File1 { get; set; }

		[ElementLocator(Id = "file2")]
		public IWebElement File2 { get; set; }

		[ElementLocator(Id = "file3")]
		public IWebElement File3 { get; set; }

		[ElementLocator(Id = "submit-button")]
		public IWebElement SubmitButton { get; set; }
	}
}
