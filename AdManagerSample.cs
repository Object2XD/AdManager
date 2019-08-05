using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Ad;

public class AdManagerSample : MonoBehaviour {

    private void Start() {
#if USE_ADMOB
        AdMobManager.Instance.Initialize(
            new AdConfigParam());
        //AdMobManager.Instance.OnAdVideoLoad(
        //    new AdVideoRequestParam() {
        //        OnAdVideoLoaded = am => am.OnAdVideoShow(),
        //        OnAdVideoFailedToLoad = am => am.OnAdVideoLoadRetry(),
        //        OnAdVideoClosed = am => am.OnAdVideoLoadRetry()
        //    });
#endif
    }


    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
#if USE_ADMOB
            AdMobManager.Instance.OnAdBannerHide();
            //AdMobManager.Instance.OnAdBannerLoad(
            //new AdBannerRequestParam() {
            //    OnAdBannerLoaded = am => am.OnAdBannerShow(),
            //    OnAdBannerFailedToLoad = am => am.OnAdBannerLoadRetry(),
            //});

            AdMobManager.Instance.OnAdVideoLoad(
                new AdVideoRequestParam() {
                    OnAdVideoLoaded = am => {
                        Debug.Log("loaded");
                        am.OnAdVideoShow();
                    },
                    OnAdVideoFailedToLoad = am => {
                        Debug.LogError("Failed");
                    },
                    OnAdVideoTimeoutToLoad = am => {
                        Debug.LogError("LoadTimeout");
                    },
                    OnAdVideoTimeoutToOpen = am => {
                        Debug.LogError("OpenTimeout");
                    },
                    OnAdVideoClosed = am => {
                        Debug.Log("Close");
                    }
                });
#endif
        }
    }
}