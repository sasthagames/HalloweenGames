using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManagerNew : MonoBehaviour
{
	public static ScoreManagerNew instance;
	
	public PlayFabManager playfabMananger;
	
	public AudioClip pointincrease;
	
    AudioSource audioSource;
	
	private void Awake()
	{
		instance = this;
	}
	
	
	public Text scoreVal; // Displays the Value of the Score
	public Text endScoreVal; //Displays the Value of the Score after game override

	public Text incScoreText;
	

	public int scores; // Stores the Value of the Score
	public  int endScores; //Stores the Value of the Score of End Score
	[SerializeField] public int scoreValue; // define How much scores to increase
	public int growthRate; //how much number of scores
	
	
	
	public static bool gameOver;
	
	public void AddPoint()
	{
		scoreVal.text = scores.ToString("0");
		endScoreVal.text = endScores.ToString("0");
		 
		scores += scoreValue;		 
			
	}
	public void RandomAddPoint(int scoreValue)
	{
		scoreVal.text = scores.ToString("0");
		endScoreVal.text = endScores.ToString("0");		 
		scores += scoreValue;		 
			
	}
	

	public void CheckPoint()
	{			
		if(scores >= 200) 
		{
			//LeanTween.moveY(Achievement1,-13,1).setEaseOutBounce();
			Debug.Log ("Player reaches"+scores);
			AchievementManager.instance.Achievementreached200();
			
			
		}
		if(scores >= 400)
		{
				AchievementManager.instance.Achievementreached400();
					 
		}
		if(scores >= 600)
		{
				AchievementManager.instance.Achievementreached600();
					 
		}
		if(scores >= 800)
		{
			AchievementManager.instance.Achievementreached800();

		}
			if(scores >= 1000) 
		{
			AchievementManager.instance.Achievementreached1000();
			
			
		}
		if(scores >= 1200)
		{
				AchievementManager.instance.Achievementreached1200();
					 
		}
		if(scores >= 1400)
		{
				AchievementManager.instance.Achievementreached1400();
					 
		}
		if(scores >= 1600)
		{
			AchievementManager.instance.Achievementreached1600();

		}
			if(scores >= 1800)
		{
				AchievementManager.instance.Achievementreached1800();
					 
		}
		if(scores >= 2000)
		{
			AchievementManager.instance.Achievementreached2000();

		}
	}
	public void GameOver()
	{
		if(endScores != scores && scores > endScores)
		{
			endScores += growthRate;
		//	 audioSource.PlayOneShot(pointincrease, 0.7F);
		//	audioSource.PlayOneShot();
		//SoundManager.PlaySound("whoosh");
			Debug.Log("End Scote " + growthRate);
		}
		playfabMananger.SendLeaderBoard(endScores);

	}
	
 
	
    // Start is called before the first frame update
    void Start()
    {
		
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		scoreVal.text = scores.ToString("0");
		endScoreVal.text = endScores.ToString("0");
       if (gameOver = true)
		{
			GameOver();
		 
		}
		
	 	CheckPoint();
    }
}
