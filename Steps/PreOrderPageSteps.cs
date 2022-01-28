using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class PreOrderPageSteps
    {
        private readonly PreOrderPage _preOrderPage;

        public PreOrderPageSteps()
        {
            _preOrderPage = new PreOrderPage();
        }

        public void MakePreOrder()
        {
            _preOrderPage.ClickOnPreOrderButton();

            if (_preOrderPage.IsUserLogged()) 
                _preOrderPage.WaitWarningWindowAppears();
        }

        public bool IsRegistrationWarningWindowAppeared()
        {
            return _preOrderPage.IsWarningWindowAppeared();
        }
    }
}
