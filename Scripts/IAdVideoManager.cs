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

        bool IsAdVideoLoadTimeout {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        void OnAdVideoLoad(AdVideoRequestParam adVideoRequestParam, float timeout = 30);

        void OnAdVideoLoadRetry();

        void OnAdVideoShow();
    }
}