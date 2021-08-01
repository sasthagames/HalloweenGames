using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KillCounter : MonoBehaviour
{
	
	public Text counterText; // Displays the Value of the Score
	
	public Text finalKillValue; //Displays the Value of the Score after game override
	
	public int kills;
	
	public AudioSource audioSource;
    
	public AudioClip clip;
    
	public float volume=0.5f;
	

	
    // Start is called before the first frame update
    void Start()
    {

    }
	
	private void ShowKills()
	{
		counterText.text = kills.ToString();
		finalKillValue.text = kills.ToString();
	
		
	}
	public void KillCount()
	{
		kills++;
		
	}
		
    // Update is called once per frame
    void Update()
    {
        ShowKills();
		CheckKills();
    }
	
	public void CheckKills()
	{
		if(kills == 1) 
		{
			KillManager.instance.FirstKill();
			audioSource.PlayOneShot(clip, volume);
	
			
		}
		if(kills == 25) 
		{
			KillManager.instance.twentyfifthKill();
	
		}
		if(kills >= 50) 
		{
			KillManager.instance.halfcenturyKill();
			
			
		}
		if(kills >= 100) 
		{
			KillManager.instance.CenturyKill();
			
		}
		if(kills >= 140) 
		{
			KillManager.instance.OneFiftyKill();
			
		}
	}
}
