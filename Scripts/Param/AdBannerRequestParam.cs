#define USE_ADMOB
#if USE_ADMOB
using GoogleMobileAds.Api;
#endif
using System;

namespace UnityEngine.Ad {
    public class AdBannerRequestParam {
        public Action<IAdBannerManager> OnAdBannerLoaded;
        public Action<IAdBannerManager> OnAdBannerFailedToLoad;
        public Action<IAdBannerManager> OnAdBannerOpening;
        public Action<IAdBannerManager> OnAdBannerClosed;
        public Action<IAdBannerManager> OnAdBannerLeavingApplication;

#if USE_ADMOB
        public string AdMobAdUnitId =
#if UNITY_ANDROID
        "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IOS
        "ca-app-pub-3940256099942544/2934735716";
#else
        "unexpected_platform";
#endif
        public AdSize AdMobAdSize = AdSize.Banner;
        public AdPosition AdMobAdPosition = AdPosition.Bottom;
#endif
    }
}