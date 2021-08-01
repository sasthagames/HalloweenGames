using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TimeTrailNew : MonoBehaviour
{
	bool timerActive = false;
	float currentTime;
	public int startMinutes;
	public Text currentTimeText;
	public Text TimeTrailTimer;
//	public AdsManager ads;

    // Start is called before the first frame update
    void Start()
    {
		#if UNITY_ANDROID
//			ads.ShowBannerAds();
		#endif
		currentTime = startMinutes * 60;
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
		{
			currentTime = currentTime - Time.deltaTime;
			if (currentTime <= 0)
			{
				timerActive = false;
			//	Start();
				Debug.Log("TimerFinished");
				RandomSpaner.stopSpawn = true;
				TimeTrailTimer.text = "GameOver";
				SoundManager.PlaySound("gameOver"); 			
				GameOverScript.instance.GameOver();
				Time.timeScale = 0;
				ScoreManagerNew.instance.GameOver();
	/*			#if UNITY_ANDROID
				ads.PlayAd();
				 #endif */
			}
		}
		TimeSpan time = TimeSpan.FromSeconds(currentTime);
		currentTimeText.text = time.Minutes.ToString() + ":" +time.Seconds.ToString();		
    }
	public void StartTimer()
	{
		timerActive = true;
	}
	public void StopTimer()
	{
		timerActive = false;
	}
}
