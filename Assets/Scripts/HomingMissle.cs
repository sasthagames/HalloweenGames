using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class HomingMissle : MonoBehaviour
{
	
	 
	
	GameObject target;
	
	public GameObject explosion;
	
	public float rotationSpeed = 15.0f;
	
	Quaternion rotateTotarget;
	
	Vector3 dir;
	
	Rigidbody2D rb;
	
	
	 public int health;

	Vector2 _direction; // the direction of the bullet
	
	bool isReady; // to know when the bullet direction is set 
	
	bool hasExploded;
	
	float radius = 3;
	
	public float force = 500;
	
	public float fieldofImpact;
	
	public LayerMask LayerToHit;
	
	//Set deaault values in Awake function
	
	void Awake()
	{
		speed = 5f;
		isReady = false;
	}
		float speed ; // the bullet speed
	
		public void SetDirection(Vector2 direction)	
	{
		// set the direction normalized, to get an unit vector
		_direction = direction.normalized;
		
		isReady = true; // set the flag is true
	}
	
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
		 rb = GetComponent<Rigidbody2D>();
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
				 
				
		dir = (target.transform.position - transform.position).normalized;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		rotateTotarget = Quaternion.AngleAxis(angle,Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation,rotateTotarget,Time.deltaTime*rotationSpeed);
		rb.velocity = new Vector2(dir.x *15,dir.y *15);
		
		}
		
    }
	 public void TakeDamage(int damage) {
      //  camAnim.SetTrigger("shake");
		SoundManager.PlaySound("enemyDieBulletSound");
		Explode();
    //    Instantiate(explosion, transform.position, Quaternion.identity);
	
		ExplodeRocket();
        health -= damage;
		
		 Destroy(gameObject);
    }
	
	public void Explode()
	{
		GameObject spawnedParticle = Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy(spawnedParticle,1);
		Debug.Log("Explode" );
		Collider[] colliders  = Physics.OverlapSphere(transform.position,radius);
		foreach(Collider nearbyObject in colliders)
		{
			Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.AddExplosionForce(force,transform.position,radius);
			
			}
		}
		
		hasExploded = true;
	}
	
	public void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position,fieldofImpact);
	}
	
	public void ExplodeRocket()
	{
		
		Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position,fieldofImpact,LayerToHit);
		
		foreach(Collider2D obj in objects)
		{
			Vector2 direction = obj.transform.position - transform.position;
			obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
		
		}
		
		CameraShaker.Instance.ShakeOnce(4,4,0.1f,1f);
		GameObject spawnedParticle = Instantiate(explosion, transform.position, Quaternion.identity);
		
		Destroy(spawnedParticle,1);
			
	}
	
	
	public void OnTriggerEnter2D(Collider2D collision)
	{		
 
		if  (collision.tag == "Player") 
		{
			 Instantiate(explosion, transform.position, Quaternion.identity);			
			Playerhealth.instance.TakeDamage(2);			 
			Destroy(gameObject);
		 
		}
		if  (collision.tag == "Ground") 
		{
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
	 
}
