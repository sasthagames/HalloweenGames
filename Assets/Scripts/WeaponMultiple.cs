using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;
public class WeaponMultiple : MonoBehaviour
{
	public static WeaponMultiple instance;
	
	public float offset;

    public GameObject projectile;
	
	
    public GameObject shotEffect;
	
    public Transform shotPoint;
	
	public Transform shotPoint1;
	
	public Transform shotPoint2;
	
	public Text ammoCounter;
	
//	public AdsManager ads;
	
	
	public int maxAmmo = 10;

	public  int isAwardedTier1 = 100;
	
	public int currentAmmo ;
	
	public float reloadTime= 1f;
	

	public void Awake()
	{
		instance = this;
	}



	
    private float timeBtwShots;
    public float startTimeBtwShots;
	
	void Start()
	{
		currentAmmo = maxAmmo;
		//currentAmmo = isAwarded;
		//	if(currentAmmo == -1)
		//		currentAmmo = maxAmmo;
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
		  // Handles the weapon rotation
		  
	/*	  currentAmmo--;
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
			
               // camAnim.SetTrigger("shake");
			   SoundManager.PlaySound("playershoot");
                Instantiate(projectile, shotPoint.position, transform.rotation);
				Instantiate(projectile, shotPoint1.position, transform.rotation);
				Instantiate(projectile, shotPoint2.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
				 CameraShaker.Instance.ShakeOnce(1.2f,0.8f,0.1f,0.15f);
				
			//	 slowMotionManager.DoSlowMotion();

				   SlowMotionManager.instance.DoSlowMotion();
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
       */
    }
//	public void onRewardedAdSuccess()
//	{
	//	Time.timeScale = 1.0f;
	//	currentAmmo = maxAmmo;
//	}
	public void Reload()
	{
		
		 Debug.Log("Reloading .............");
		 currentAmmo = maxAmmo;
	//	ads.PlayRewardedAd(onRewardedAdSuccess);		
		
	}
	public void ShopReload()
	{
		
		 Debug.Log("WeaponMultiple .............");
		 currentAmmo = isAwardedTier1;
	//	ads.PlayRewardedAd(onRewardedAdSuccess);		
		
	}
	public void Shoot()
	{
		  // Handles the weapon rotation
		
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0) && Time.timeScale != 0)
            {
			  currentAmmo--;
               // camAnim.SetTrigger("shake");
			   SoundManager.PlaySound("bullettime");
                Instantiate(projectile, shotPoint.position, transform.rotation);
				Instantiate(projectile, shotPoint1.position, transform.rotation);
				Instantiate(projectile, shotPoint2.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
				 CameraShaker.Instance.ShakeOnce(1.2f,0.8f,0.1f,0.15f);
				
			//	 slowMotionManager.DoSlowMotion();

				   SlowMotionManager.instance.DoSlowMotion();
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
	}
}
