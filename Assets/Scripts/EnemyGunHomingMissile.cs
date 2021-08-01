using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunHomingMissile : MonoBehaviour
{
	
	float speed ; // the bullet speed
	
	Vector2 _direction; // the direction of the bullet
	
	bool isReady; // to know when the bullet direction is set
	
	 

	void Awake()
	{
		speed = 5f;
		isReady = false;
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
				
	
			}
			 
    }
}
