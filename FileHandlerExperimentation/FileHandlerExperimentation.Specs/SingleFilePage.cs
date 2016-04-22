using OpenQA.Selenium;
using SpecBind.Helpers;
using SpecBind.Pages;
using TechTalk.SpecFlow;

namespace FileHandlerExperimentation.Specs
{
	[PageNavigation("/")]
	public class SingleFilePage
	{
		[ElementLocator(Id = "file")]
		public IWebElement File { get; set; }

		[ElementLocator(Id = "submit-button")]
		public IWebElement SubmitButton { get; set; }
	}

	[Binding]
	public class TestStep
	{
		[Given("Testing")]
		public void Testing()
		{
			ResourceLocator.GetResource("file1.txt");
		}
	}
}
