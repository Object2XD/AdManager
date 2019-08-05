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
        /// 動画の読み込み
        /// </summary>
        void OnAdVideoLoad(AdVideoRequestParam adVideoRequestParam, float timeout = 30);

        /// <summary>
        /// 設定そのままで再読み込みする場合の処理
        /// </summary>
        void OnAdVideoLoadRetry();

        /// <summary>
        /// 広告動画の表示
        /// </summary>
        void OnAdVideoShow();
    }
}