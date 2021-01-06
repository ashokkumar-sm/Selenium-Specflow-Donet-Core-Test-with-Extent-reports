//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;

//namespace SeleniumDonetCoreTest
//{
//	public class Tests
//	{

//		public IWebDriver Driver;

//		[SetUp]
//		public void Setup()
//		{

//			Driver = new ChromeDriver();
//			Console.WriteLine("Setup");
//		}

//		[Test]
//		public void Test1()
//		{
//			Driver.Navigate().GoToUrl ("https://demowf.aspnetawesome.com/");
//			Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Apple");
//			Driver.FindElement(By.XPath("//input[@name='itemContentPlaceHolder1_ParentCat']/following-sibling::div[text()='Fruits']")).Click();
			
//			Assert.Pass();
//	}
//	}
//	}

