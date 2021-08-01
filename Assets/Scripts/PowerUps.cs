using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
	
		
	public int health;
    
	public GameObject deathEffect;
    
	public GameObject explosion;
	
	public GameObject dropLoopPrefab;
	
	GameObject _dropLoopTarget;
	
	 public void FollowPrefab()
	 {
		var go = Instantiate(dropLoopPrefab, transform.position+ new Vector3(0,Random.Range(0,2)), Quaternion.identity);
		
		go.GetComponent<Follow>().Target = _dropLoopTarget.transform;
	 }
    // Start is called before the first frame update
    void Start()
    {
        _dropLoopTarget = GameObject.FindGameObjectWithTag("DropLootTracker");
    }
	  
	public void OnTriggerEnter2D(Collider2D collision)
	{
/*		if(collision.tag == "Ground")
		{
		//	SoundManager.PlaySound("powerup");
			 Instantiate(explosion, transform.position, Quaternion.identity);		
			 Destroy(gameObject);
	
		}*/
	}
	public void TakeDamage(int damage) {
      //  camAnim.SetTrigger("shake");
	 
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        health -= damage;
		Playerhealth.instance.Heal(1);
		FollowPrefab();
		Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
		{
            Instantiate(deathEffect, transform.position, Quaternion.identity);	 
		//	 FollowPrefab();
		    Destroy(gameObject);
        }
    }
}
