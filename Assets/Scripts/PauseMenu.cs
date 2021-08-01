using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
	public GameObject pauseMenu;
	public  bool isPasued;
    // Start is called before the first frame update
    void Start()
    {
        
	
    }

    // Update is called once per frame
    void Update()
    {
		 
    }
	public void MainMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("MainScreen");
	}
	public void presspause()
	{
		if (isPasued)
		{
			ResumeGame();
		}
		else
		{
			PauseGame();
		}
	}
	public void ResumeGame()
	{
		 pauseMenu.SetActive(false);
		  Time.timeScale = 1;
		  isPasued = false;
	}
	public void PauseGame()
	{
		isPasued = true;
		 Time.timeScale = 0;
		  pauseMenu.SetActive(true);
		  Debug.Log("Paused");
		 
		 
		  
	}
	public void PauseGameSurival()
	{
			if(isPasued == true)
			{
			
				Time.timeScale = 0;
				pauseMenu.SetActive(true);
				Debug.Log("PausedSurvial if ");
			}
			else{
				Time.timeScale = 0;
				pauseMenu.SetActive(true);
				Debug.Log("PausedSurvial else");
			}
		 
		 
		  
	}
		public void restartTimeTrail()
	{
		 Time.timeScale = 1;
		 //isPasued = false;
		SceneManager.LoadScene("TimeTrail");
		 
		
	}
	public void restartSuruvialMode()
	{
		 Time.timeScale = 1;
	//	isPasued = false;
		SceneManager.LoadScene("SurvialMode");
		  
		 
	}
 
}
