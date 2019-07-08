namespace UnityEngine.Ad {
    public interface IAdVideoManager : IAdManager {
        bool IsAdVideoLoading {
            get;
        }

        bool IsAdVideoLoaded {
            get;
        }

        bool IsAdVideoRewarded {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        void OnAdVideoLoad(AdVideoRequestParam adVideoRequestParam);

        void OnAdVideoLoadRetry();

        void OnAdVideoShow();
    }
}