using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;

public class WeaponRailGun : MonoBehaviour
{

	public static WeaponRailGun instance;
	
    public float offset;

    public GameObject projectile;
	
   	public GameObject shotEffect;
   
   public Transform shotPoint;

	public Text ammoCounter;
	
	public int maxAmmo = 20;
	
	public int currentAmmo ;
	
	public float reloadTime= 1f;
	
	public  int isAwardedTier1 = 100;
	
	
    private float timeBtwShots;

    public float startTimeBtwShots;
	
	
	public void Awake()
	{
		instance = this;
	}
	
	void Start()
	{

		currentAmmo = maxAmmo;

	}

    private void Update()
    {
		
		ammoCounter.text = currentAmmo.ToString();

		Shoot();

      	if (currentAmmo <=  0)
		{
		//	Time.timeScale = 0.0f;

			Reload();
			return;
			
		}

       
    }
	

	public void Reload()
	{
		currentAmmo = maxAmmo;

		 Debug.Log("Reloading .............");
		 
			
		
	}
	public void ShopReload()
	{
		
		 Debug.Log("Rail Gun Shop reload .");

		 currentAmmo = isAwardedTier1;
	//	ads.PlayRewardedAd(onRewardedAdSuccess);		
		
	}

	
	public void Shoot()
	{
		  // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

		 difference.Normalize();

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0 )
        {
            if (Input.GetMouseButton(0)&& Time.timeScale != 0)
            {
				currentAmmo--;

			   SoundManager.PlaySound("playershoot");

                Instantiate(projectile, shotPoint.position, transform.rotation);

                timeBtwShots = startTimeBtwShots;

     			 CameraShaker.Instance.ShakeOnce(1.2f,0.8f,0.1f,0.15f);
				 
            }
        }
        else 
		{
        
			timeBtwShots -= Time.deltaTime;

        }
	}
}
