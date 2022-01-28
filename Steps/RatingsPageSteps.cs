using System;
using System.Collections.Generic;
using System.Linq;
using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class RatingsPageSteps
    {
        private readonly RatingsPage _ratingsPage;

        public RatingsPageSteps()
        {
            _ratingsPage = new RatingsPage();
        }

        public void SortRatingsBy(string sortingValue)
        {
            _ratingsPage.ClickOnRatingCategoryDropdown();
            _ratingsPage.ClickOnRatingsCategory(sortingValue);
        }

        public int CountRecords()
        {
            return _ratingsPage.GetRecordsNumber();
        }

        public bool IsCorrectLevelValuesDisplayed()
        {
            List<int> levelValues = _ratingsPage.GetLevelsValue().Select(lv => Int32.Parse(lv)).ToList();

            return levelValues.All(value => value > 0 && value < 100);
        }
    }
}
