using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
	public GameObject Achievement1;
	public GameObject Achievement2;
	public GameObject Achievement3;
	public GameObject Achievement4;
	public GameObject Achievement5;
	public GameObject Achievement6;
	public GameObject Achievement7;
	public GameObject Achievement8;
	public GameObject Achievement9;
	public GameObject Achievement10;


 
	public static AchievementManager instance;
	private void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
	
    	
	}
	public void Achievementreached200()
	{
		Achievement1.SetActive(true);
	
	}
	public void Achievementreached400()
	{
		Achievement2.SetActive(true);
			
	}
	public void Achievementreached600()
	{
		Achievement3.SetActive(true); 	 
	
	}
	public void Achievementreached800()
	{
		Achievement4.SetActive(true);	 
	
	}
	public void Achievementreached1000()
	{
		Achievement5.SetActive(true);
	
	}
	public void Achievementreached1200()
	{
		Achievement6.SetActive(true); 
	
	}
	public void Achievementreached1400()
	{
		Achievement7.SetActive(true); 	 
	
	}
	public void Achievementreached1600()
	{
		Achievement8.SetActive(true);	 
	
	}
	public void Achievementreached1800()
	{
		Achievement9.SetActive(true); 	 
	
	}
	public void Achievementreached2000()
	{
		Achievement10.SetActive(true);	 
		  
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
