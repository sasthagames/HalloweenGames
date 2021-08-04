using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject SinglePlayerprefab;
	public GameObject MainmenuPrefab;
	public GameObject Helpprefab;
	//public GameObject PlayFabUserName;
	
	//public GameObject canvas;
	
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void SinglePlayer()
	{
		
	}
	public void PlayFab()
	{
		SinglePlayerprefab.SetActive(false);		
		MainmenuPrefab.SetActive(false);	
		Helpprefab.SetActive(false);
	//	PlayFabUserName.SetActive(true);
		
	}

	public void Options()
	{
		
	}
	public void Help()
	{

		SinglePlayerprefab.SetActive(false);		
		MainmenuPrefab.SetActive(false);	
		Helpprefab.SetActive(true);
	//	canvas.SetActive(false);
	}
	public void TimeTrail()
	{
		SceneManager.LoadScene("TimeTrail");
	}
	public void Surival()
	{
		SceneManager.LoadScene("SurvialMode");
	}
	public void OPtionstoMainmenu()
	{
		SinglePlayerprefab.SetActive (false);
		MainmenuPrefab.SetActive(true);
		
	}
}
