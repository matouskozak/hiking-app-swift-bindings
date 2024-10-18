using UIKit;

namespace HikingApp.MacCatalyst.ViewControllers
{
    public class MainViewController : UITabBarController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var exploreViewController = new ExploreViewController();
            var myTrailsViewController = new MyTrailsViewController();

            var exploreNavigationController = new UINavigationController(exploreViewController)
            {
                TabBarItem = new UITabBarItem("Explore", UIImage.FromBundle("explore_icon.png"), 0)
            };

            var myTrailsNavigationController = new UINavigationController(myTrailsViewController)
            {
                TabBarItem = new UITabBarItem("My Trails", UIImage.FromBundle("mytrails_icon.png"), 1)
            };

            ViewControllers = new UIViewController[]
            {
                exploreNavigationController,
                myTrailsNavigationController,
            };
        }
    }
}
