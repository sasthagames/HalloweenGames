using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunHoming : MonoBehaviour
{
	public GameObject EnemyBulletGo;  // Enemy Bullet prefab
	
	
    // Start is called before the first frame update
    void Start()
    {
         Invoke("FireEnemyBullet",3f);
    }


	void FireEnemyBullet()
	{
		GameObject playerShip = GameObject.FindGameObjectWithTag ("Player");
		
		if (playerShip != null)
		{
			 GameObject bullet = (GameObject)Instantiate(EnemyBulletGo);
			 
			 SoundManager.PlaySound("homingmissile");
			 //Sound
			 bullet.transform.position = transform.position;
		//	  Debug.Log("EnemyBulletGo ............."+ bullet.transform.position + "" );
			 // compute the bullet direction towards the playerShip
			 Vector2 direction = playerShip.transform.position - bullet.transform.position;
			 
			 // set the bullet direction
			 
			 bullet.GetComponent<HomingMissle>().SetDirection(direction);
			 
			 
		}
	}
	

    // Update is called once per frame
    void Update()
    {
        
    }
}
