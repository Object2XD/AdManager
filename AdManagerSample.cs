using UnityEngine;
using UnityEngine.Ad;

public class AdManagerSample : MonoBehaviour {
    private void Start() {
        AdMobManager.Instance.Initialize(
            new AdConfigParam());
        //AdMobManager.Instance.OnAdVideoLoad(
        //    new AdVideoRequestParam() {
        //        OnAdVideoLoaded = am => am.OnAdVideoShow(),
        //        OnAdVideoFailedToLoad = am => am.OnAdVideoLoadRetry(),
        //        OnAdVideoClosed = am => am.OnAdVideoLoadRetry()
        //    });
    }


    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            AdMobManager.Instance.OnAdBannerHide();
            AdMobManager.Instance.OnAdBannerLoad(
            new AdBannerRequestParam() {
                OnAdBannerLoaded = am => am.OnAdBannerShow(),
                OnAdBannerFailedToLoad = am => am.OnAdBannerLoadRetry(),
            });

            AdMobManager.Instance.OnAdVideoLoad(
                new AdVideoRequestParam() {
                    OnAdVideoLoaded = am => am.OnAdVideoShow(),
                    OnAdVideoFailedToLoad = am => am.OnAdVideoLoadRetry(),
                    OnAdVideoClosed = am => am.OnAdVideoLoadRetry()
                });
        }
    }
}