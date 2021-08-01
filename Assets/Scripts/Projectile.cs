using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
	public int amount;
	
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;
	
	  private GameObject currentTeleporter;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null) {
            if (hitInfo.collider.CompareTag("Enemy")) 
			{
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }			
 
			if (hitInfo.collider.CompareTag("PowerUps"))
			{
                hitInfo.collider.GetComponent<PowerUps>().TakeDamage(damage);
            }
			if (hitInfo.collider.CompareTag("EnemyBulletTag")) 
			{
               hitInfo.collider.GetComponent<EnemyBullet>().TakeDamage(damage);
			 
            }			
			if (hitInfo.collider.CompareTag("EnemyRocket")) 
			{
               hitInfo.collider.GetComponent<HomingMissle>().TakeDamage(damage);			 
            }		
				if (hitInfo.collider.CompareTag("SkullPowerup"))
			{
                hitInfo.collider.GetComponent<SkullPowerup>().TakeDamage(damage);
            }
			
		/*	if (hitInfo.collider.CompareTag("Heal")) {
                hitInfo.collider.GetComponent<Playerhealth>().Heal(damage);
			 Debug.Log("Heal");
            }*/
		
		/*	 if (hitInfo.collider.CompareTag("TimetrailGround")) {
               SoundManager.PlaySound("gameOver"); 
            }*/
            DestroyProjectile();
        }


        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

  
    void DestroyProjectile() {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
