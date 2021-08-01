using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using System;
//public class AdsManager : MonoBehaviour,IUnityAdsListener
//public class AdsManager
public class AdsManager : MonoBehaviour
{
/*	public static AdsManager instance; 
	 static int loadCount = 0;
	
	void Awake()
	{
		
		instance= this;
	}
	#if UNITY_IOS
    private string gameId = "4192320";
    #elif UNITY_ANDROID
    private string gameId = "4192321";
    #endif
    // Start is called before the first frame update
    bool testMode = true;
	
	Action onRewardedAdSuccess;

    void Start () {
        // Initialize the Ads service:
    //    Advertisement.Initialize(gameId, testMode);
	//	Advertisement.AddListener(this);
	//	ShowBannerAds();
    }
	public void ShowBannerAds()
	{
		if (Advertisement.IsReady("banner"))
			{
       
			Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
			Advertisement.Banner.Show("banner");
			Debug.Log("banner ");
			
         // Replace mySurfacingId with the ID of the placements you wish to display as shown in your Unity Dashboard.
        } 
		 else
			 {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
		RepeatShowBanner ();
	}
	 
		}
		 IEnumerator RepeatShowBanner () {
        while (!Advertisement.isInitialized) {
            yield return new WaitForSeconds(0.5f);
			 ShowBannerAds();
        }
        Advertisement.Banner.Show ("banner");
		
    }
 
    public void PlayAd()
	{
		if(Advertisement.IsReady("video"))
		{
			Advertisement.Show("video");
		}
	}
	
	
	 public void PlayRewardedAd( Action onSuccess)
	 {
		 onRewardedAdSuccess = onSuccess;
		 if(Advertisement.IsReady("rewardedVideo"))
		{
			Advertisement.Show("rewardedVideo");
		}
		else{
			Debug.Log("Rewared ad is not ready ! Please try again later!");
		}
		
	 }
	 
	 
	
	 public void OnUnityAdsReady(string placementId)
	 {
		 	Debug.Log("Ads are ready");
	 }
	 public void OnUnityAdsDidError(string message)
	 {
		 Debug.Log("ERROR" + message);
	 }
	  public void OnUnityAdsDidStart(string placementId)
	 {
		 	Debug.Log("Video Started");
	 }
	  public void OnUnityAdsDidFinish(string placementId,ShowResult showResult)
	  {
		  if(placementId == "rewardedVideo" && showResult == ShowResult.Finished)
		  {
			  onRewardedAdSuccess.Invoke();
			   	Debug.Log("Player Should Be Awaded");
				Advertisement.RemoveListener(this);
		  }
		
	  }
	     // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy() {
        Advertisement.RemoveListener(this);
    }
	*/
}
