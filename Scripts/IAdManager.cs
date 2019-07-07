namespace UnityEngine.Ad {
    /// <summary>
    /// 広告管理の基本インターフェース
    /// </summary>
    public interface IAdManager {

        /// <summary>
        /// 初期化済みかどうか
        /// </summary>
        bool IsInitialized {
            get;
        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="adConfigParam"></param>
        void Initialize(AdConfigParam adConfigParam);
    }
}