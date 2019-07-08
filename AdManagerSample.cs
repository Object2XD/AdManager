using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Ad;

public class AdManagerSample : MonoBehaviour {
    private List<string> log = new List<string>();

    private void Start() {
        Application.logMessageReceived += (msg, trace, type) => { log.Add(msg); };

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
                        Debug.LogError("Timeout");
                    },
                    OnAdVideoClosed = am => {
                        Debug.Log("Close");
                    }
                });
        }
    }

    private void OnGUI() {
        for (int i = log.Count - 1; Mathf.Max(log.Count - 11, 0) <= i; i--) {
            GUI.Label(new Rect(0, 16 * (log.Count - 1 - i), Screen.width, Screen.height), log[i]);
        }
    }
}