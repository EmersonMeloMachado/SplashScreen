using UIKit;
using Airbnb.Lottie;

namespace SplashScreen.iOS
{
    public partial class SplashScreenViewController : UIViewController
    {
        public SplashScreenViewController() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var animationView = LOTAnimationView.AnimationNamed("Logo");

            this.View.AddSubview(animationView);
            animationView.PlayWithCompletion((animationFinished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching(UIApplication.SharedApplication,
                                                                           new Foundation.NSDictionary());
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}