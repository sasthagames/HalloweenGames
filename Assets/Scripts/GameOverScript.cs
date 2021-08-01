using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
	public static GameOverScript instance;
	public GameObject GameOverScreen;
	public GameObject Leaderboard;
	 
    // Start is called before the first frame update
    void Start()
    {
        
    }
	private void Awake()
	{
		instance = this;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	public void Backtogameover()
	{
		GameOverScreen.SetActive(true);
		Leaderboard.SetActive(false);
	}

	public void GetLeaderBoardPlayfab()
	{
		GameOverScreen.SetActive(false);
		Leaderboard.SetActive(true);
	
	}
	public void restartTimeTrail()
	{
		 Time.timeScale = 1;
	//	SceneManager.LoadScene("TimeTrail");
		
	}
	public void restartSuruvialMode()
	{
		 Time.timeScale = 1;
	//	SceneManager.LoadScene("SurvialMode");
		 
	}
	public void MainMenu()
	{
		 Time.timeScale = 1;
	//	SceneManager.LoadScene("MainScreen");
		 Debug.Log("MainMenu"+ Time.timeScale);


	}
	public void GameOver()
	{		
		GameOverScreen.SetActive(true);
	}
	
}
