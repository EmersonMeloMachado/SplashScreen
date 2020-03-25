using Android.OS;
using Android.App;
using Android.Content;
using Android.Animation;
using Com.Airbnb.Lottie;

namespace SplashScreen.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class MinhaSplashScreenAnimadaActivity : Activity, Animator.IAnimatorListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_MinhaSplashScreen);

            LottieAnimationView animationView = FindViewById<LottieAnimationView>(Resource.Id.animation_view);

            animationView.AddAnimatorListener(this);
        }

        public void OnAnimationCancel(Animator animation)
        {
        }

        public void OnAnimationEnd(Animator animation)
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        public void OnAnimationRepeat(Animator animation)
        {
        }

        public void OnAnimationStart(Animator animation)
        {
        }
    }
}