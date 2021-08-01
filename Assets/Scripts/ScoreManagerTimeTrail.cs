using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerTimeTrail : MonoBehaviour
{
	
	public static ScoreManagerTimeTrail instance;
	
	public Text scoreVal; // Displays the Value of the Score
	
	public Text endScoreVal; //Displays the Value of the Score after game override
	
	public Text incScoreText;
	
	public int scores; // this will stores the value of scores
	
	public  int endScores; //Stores the Value of the Score of End Score
	
	public int scoreValue; // define How much scores to increase
	
	public int growthRate; //how much number of scores
	
	public static bool gameOver;
	
	private void Awake()
	{
		instance = this;
	}
	
	
	public void AddPoint()
	{
		scoreVal.text = scores.ToString("0");
		endScoreVal.text = endScores.ToString("0");		 
		scores += scoreValue;		 
			
	}
	public void GameOver()
	{
		Debug.Log("End Scote ");
		if(endScores != scores && scores > endScores)
		{
			endScores += growthRate;
		//	 audioSource.PlayOneShot(pointincrease, 0.7F);
			Debug.Log("End Scote " + growthRate);
		}
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreVal.text = scores.ToString("0");
		endScoreVal.text = endScores.ToString("0");
       if (gameOver == true)
		{
			GameOver();
		 Debug.Log("End Scote Update " );
		}
		
	 	CheckPoint();
    }
	public void CheckPoint()
	{			
		if(scores == 200) 
		{
			//LeanTween.moveY(Achievement1,-13,1).setEaseOutBounce();
			Debug.Log ("Player reaches"+scores);
			AchievementManager.instance.Achievementreached200();
			
			
		}
		if(scores == 400)
		{
				AchievementManager.instance.Achievementreached400();
					 
		}
		if(scores == 600)
		{
				AchievementManager.instance.Achievementreached600();
					 
		}
		if(scores == 800)
		{
			AchievementManager.instance.Achievementreached800();

		}
			if(scores == 1000) 
		{
			//LeanTween.moveY(Achievement1,-13,1).setEaseOutBounce();
			Debug.Log ("Player reaches"+scores);
			AchievementManager.instance.Achievementreached1000();
			
			
		}
		if(scores == 1200)
		{
				AchievementManager.instance.Achievementreached1200();
					 
		}
		if(scores == 1400)
		{
				AchievementManager.instance.Achievementreached1400();
					 
		}
		if(scores == 1600)
		{
			AchievementManager.instance.Achievementreached1600();

		}
			if(scores == 1800)
		{
				AchievementManager.instance.Achievementreached1800();
					 
		}
		if(scores == 2000)
		{
			AchievementManager.instance.Achievementreached2000();

		}
	}
}
