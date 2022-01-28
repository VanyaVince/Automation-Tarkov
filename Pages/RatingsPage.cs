using OpenQA.Selenium;
using System.Collections.Generic;
using Tarkov.Data.Css;
using Tarkov.Driver;
using Tarkov.ElementWrapper;
using Tarkov.ElementWrapper.Elements;

namespace Tarkov.Pages
{
    public class RatingsPage
    {
        private string _ratingCategory = "//li[@data-val='{0}']";
        private Element RatingCategoryDropdown => new Element(By.XPath("//div[@data-name='category']"));
        private Element RatingLoader => new Element(By.XPath("//div[@id='ratingLoader']"));
        private Elements Records => new Elements(By.XPath("//div[contains(@class, 'table')]//tr"));
        private Elements LevelsValues => new Elements(By.XPath("//div[contains(@class, 'table')]//td[@data-col-name= 'Lvl']"));

        public void ClickOnRatingCategoryDropdown()
        {
            WaitRatingLoaderIsDone();
            RatingCategoryDropdown.Click();
        }

        public void ClickOnRatingsCategory(string category)
        {
            new Element(By.XPath(string.Format(_ratingCategory, category))).Click();
            WaitRatingLoaderIsDone();
        }

        public List<string> GetLevelsValue()
        {
            return LevelsValues.GetText();
        }

        public int GetRecordsNumber()
        {
            return Records.CountElements();
        }

        private void WaitRatingLoaderIsDone()
        {
            DriverManager.Wait().Until(waiting =>
            {
                return RatingLoader.GetCssAttributeValue(Attributes.Display) == CssValue.None;
            });
        }
    }
}
