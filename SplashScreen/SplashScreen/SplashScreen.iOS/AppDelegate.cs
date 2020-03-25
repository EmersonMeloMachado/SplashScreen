using UIKit;
using Foundation;
using Lottie.Forms.iOS.Renderers;

namespace SplashScreen.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            if(Window == null)
            {
                Window = new UIWindow(frame: UIScreen.MainScreen.Bounds);
                var initialViewController = new MinhaSplashScreenAnimadaViewController();
                Window.RootViewController = initialViewController;
                Window.MakeKeyAndVisible();

                return true;
            }
            else
            {
                global::Xamarin.Forms.Forms.Init();
                AnimationViewRenderer.Init();
                LoadApplication(new App());

                return base.FinishedLaunching(app, options);
            }
        }
    }
}
