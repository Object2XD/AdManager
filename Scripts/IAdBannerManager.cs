namespace UnityEngine.Ad {
    public interface IAdBannerManager : IAdManager {
        bool IsAdBannerLoading {
            get;
        }

        bool IsAdBannerLoaded {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        void OnAdBannerLoad(AdBannerRequestParam adBannerRequestParam);

        void OnAdBannerLoadRetry();

        void OnAdBannerShow();
        void OnAdBannerHide();
    }
}