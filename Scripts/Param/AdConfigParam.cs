namespace UnityEngine.Ad {
    public class AdConfigParam {
#if USE_ADMOB
        public string AdMobAppId =
#if UNITY_ANDROID
        "ca-app-pub-3940256099942544~3347511713";
#elif UNITY_IOS
        "ca-app-pub-3940256099942544~1458002511";
#else
        "unexpected_platform";
#endif
#endif
    }
}
