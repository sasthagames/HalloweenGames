using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthMiniGame : MonoBehaviour
{
	
	public static PlayerHealthMiniGame instance;
	
	public HealthBar healthBar;
	
	public int maxhealth = 10;
	
	public int currentHealth ;
	
	void Awake()
	{
		instance = this;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(maxhealth);
		
    }


	public void Death()
	 {
		RandomSpaner.stopSpawn = true;			
		
		ScoreManagerNew.instance.GameOver();
		
		SoundManager.PlaySound("gameOver"); 
			
		if(ScoreManagerNew.gameOver == true)
		{
				Time.timeScale = 0;

				GameOverScript.instance.GameOver();

		}	
	 }
	 
	  public void Damage(int amount)
 {
		currentHealth -= amount;

 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
