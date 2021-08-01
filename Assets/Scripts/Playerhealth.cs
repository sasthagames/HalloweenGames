using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Playerhealth : MonoBehaviour
{
	public static Playerhealth instance;
	
	public int currentHealth ;
	
	public int maxhealth = 10;

//	public Text health;

	KillCounter killcounter;

//	public AdsManager ads;

    public Vector3 pos1 = new Vector3(30,-12,0);

	public Vector3 pos2 = new Vector3(-18,-12,0);
	
	public GameObject floatingTextPrefab;
	
	public bool isPressed = false;

	public bool dirRight = true;
    
        
	public float speed = 100.0f;
	
	public HealthBar healthBar;

	
	
    // Start is called before the first frame update
	void Awake()
	{
		instance = this;
	}
    void Start()
    {
		currentHealth = maxhealth;
		
		healthBar.SetMaxHealth(maxhealth);
		
		isPressed = false;
		
		killcounter = GameObject.Find("KCO").GetComponent<KillCounter>();

    }
	 public void ShowFlotingText()
	 {
		var go =  Instantiate(floatingTextPrefab,transform.position,Quaternion.identity,transform);
		
		go.GetComponent<TextMesh>().text = currentHealth.ToString();
	 
	 }
		
	 public void TakeDamage(int amount)
	 {
	 currentHealth -= amount;
	 
	 healthBar.SetHealth(currentHealth);
	 
	 if (floatingTextPrefab  && currentHealth > 0)
	 {
	
		ShowFlotingText();
	 
	 }
		if (currentHealth <= 0)
		{
			
			Death();
			
		}       
		
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
 
 public void Heal(int amount)
 {
		currentHealth += amount;
		
//	if (currentHealth > maxhealth)

//		{
			//	currentHealth = maxhealth;
//		}

 }
 public void Damage(int amount)
 {
		currentHealth -= amount;

 }
  
    // Update is called once per frame
    void Update()
    {
      //  health.text = currentHealth.ToString();
		if (currentHealth == 0)
		{
			Death();

		//	Time.timeScale = 0;
		}
		
		 ChangePlayerPos();
	
		
    }

	public void ChangePlayerPos()
	{	     
 	      if(isPressed == true)
		   {
			
			transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
			
			Debug.Log("ChangePlayerPos" );
	
	}
	 
   /*
    if (Input.GetKeyDown("space"))
        {
		if(isPressed = true)
		{
           transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
        }
		}

  */
	}
}
