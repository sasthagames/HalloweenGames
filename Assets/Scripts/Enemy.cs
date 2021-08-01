using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  //  public Animator camAnim;
    public int health;
	
    public GameObject deathEffect;
	
    public GameObject explosion;
	
	public GameObject dropLoopPrefab;
	
	GameObject _dropLoopTarget;
	
	
	KillCounter killcounter;
	
	public static Enemy instance;
	
	void Start()
	{
		_dropLoopTarget = GameObject.FindGameObjectWithTag("DropLootTracker");
		killcounter = GameObject.Find("KCO").GetComponent<KillCounter>();
	}
	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Ground")
		{
			 SoundManager.PlaySound("enemyDieground");
			 Instantiate(explosion, transform.position, Quaternion.identity);
			 Playerhealth.instance.TakeDamage(1);
			 Destroy(gameObject);
			
			//health -= damage;
			//Debug.Log("Grounded");
		}
		if(collision.tag == "TimetrailGround")
		{
			SoundManager.PlaySound("enemyDieground");
			 Instantiate(explosion, transform.position, Quaternion.identity);
			 Destroy(gameObject);
			
		}
	}

    public void TakeDamage(int damage) {
      //  camAnim.SetTrigger("shake");
		SoundManager.PlaySound("enemyDieBulletSound");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        health -= damage;
		
		 //Destroy(gameObject);
    }
	 
	 public void FollowPrefab()
	 {
		var go = Instantiate(dropLoopPrefab, transform.position+ new Vector3(0,Random.Range(0,2)), Quaternion.identity);
		
		go.GetComponent<Follow>().Target = _dropLoopTarget.transform;
	 }
	

	 void Update()
    {
        if (health <= 0)
			{
            Instantiate(deathEffect, transform.position, Quaternion.identity);	 
			
			FollowPrefab();
			
			ScoreManagerNew.instance.RandomAddPoint(Random.Range(10,40));
			
			killcounter.KillCount();
				
            Destroy(gameObject);
        }
    }
}
