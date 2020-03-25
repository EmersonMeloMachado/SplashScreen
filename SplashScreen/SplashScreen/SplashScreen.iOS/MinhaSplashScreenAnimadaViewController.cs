using UIKit;
using Airbnb.Lottie;

namespace SplashScreen.iOS
{
    public partial class MinhaSplashScreenAnimadaViewController : UIViewController
    {
        public MinhaSplashScreenAnimadaViewController() : base() { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var viewAnimation = LOTAnimationView.AnimationNamed("Logo");

            View.AddSubview(viewAnimation);
            viewAnimation.PlayWithCompletion((finished) =>
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