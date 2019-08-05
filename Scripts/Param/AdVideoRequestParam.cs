//#define USE_ADMOB

using System;

namespace UnityEngine.Ad {
    public class AdVideoRequestParam {
        public Action<IAdVideoManager> OnAdVideoLoaded;
        public Action<IAdVideoManager> OnAdVideoFailedToLoad;
        public Action<IAdVideoManager> OnAdVideoTimeoutToLoad;
        public Action<IAdVideoManager> OnAdVideoFailedToShow;
        public Action<IAdVideoManager> OnAdVideoOpening;
        public Action<IAdVideoManager> OnAdVideoTimeoutToOpen;
        public Action<IAdVideoManager> OnAdVideoStarted;
        public Action<IAdVideoManager> OnAdVideoRewarded;
        public Action<IAdVideoManager> OnAdVideoClosed;
        public Action<IAdVideoManager> OnAdVideoLeavingApplication;

#if USE_ADMOB
        public string AdMobAdUnitId =
#if UNITY_ANDROID
        "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IOS
        "ca-app-pub-3940256099942544/1712485313";
#else
        "unexpected_platform";
#endif
#endif
    }
}
