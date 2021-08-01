using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
	 public int health;
	float speed ; // the bullet speed
	public GameObject deathEffect;
	public GameObject explosion;
	
	
	Vector2 _direction; // the direction of the bullet
	
	bool isReady; // to know when the bullet direction is set 
	
	//Set deaault values in Awake function
	
	void Awake()
	{
		speed = 5f;
		isReady = false;
	}
	
	
	   public void TakeDamage(int damage) {
      //  camAnim.SetTrigger("shake");
		SoundManager.PlaySound("enemyDieBulletSound");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        health -= damage;
		
		 Destroy(gameObject);
    }
	// Function to set the bullets direction
	public void SetDirection(Vector2 direction)	
	{
		// set the direction normalized, to get an unit vector
		_direction = direction.normalized;
		
		isReady = true; // set the flag is true
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public void OnTriggerEnter2D(Collider2D collision)
	{		
	//	if ((collision.tag == "Ground") || (collision.tag == "Player"))
		if  (collision.tag == "Player") 
		{
			 Instantiate(explosion, transform.position, Quaternion.identity);			
			Playerhealth.instance.TakeDamage(1);			 
			Destroy(gameObject);
		 
		}
		if  (collision.tag == "Ground") 
		{
			 Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
	
	
 
    // Update is called once per frame
    void Update()
    {
		 
			if (isReady)
			{
		//	 Debug.Log("EnemyBullet ............."+ isReady + "" );
				// get the bullet current position
				Vector2 position = transform.position;
				
				// comute the bullet new position
				
				position += _direction * speed * Time.deltaTime;
				
				// update the bullet position
				
				transform.position = position;
				
			//	Debug.Log(transform.position +""+ position + "" );
				
	/*			// Remove the bullet from our game
				
				// this is the botton of the screen
				
				Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
				
				
				// this is the top right  of the screen
				
				Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
				
				
				// if the bullet goes outside the screen
				
				if ((transform.position.x < min.x) || (transform.position.x > max.x)||
					(transform.position.y < min.y) || (transform.position.y > max.y))
					{
						Destroy(gameObject);
					}*/
			}
			 
    }
}
