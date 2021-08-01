using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public Text scoreText;
	public Text highscoreText;
	private int scoreAmount ;
	public Text endScoreVal;
	int score =0;
	int randomscore;
	int highscore =0;
	public int endScore;
	public bool Gameover;
	private void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
		highscore = PlayerPrefs.GetInt("highscore",0);
		
        scoreText.text = score.ToString() + "POINTS";
		highscoreText.text = "HIGHSCORE : " + highscore.ToString();
		scoreAmount = 0;
	//	scoreAmount +=  
    }
	
	public void AddPoint()
	{
		score += 1;
		 scoreText.text = score.ToString();
		//  scoreText.text = score.ToString() + "POINTS";
		 PlayerPrefs.SetInt("highscore",score);
	}
	public void AddRandomAndPoint(int randomscoreValue)
	{
		scoreAmount = randomscoreValue;
	}
 public void FinalScore( )
 {
	 scoreText.text = score.ToString("0") ;
	 endScoreVal.text =  endScore.ToString("0");
 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
