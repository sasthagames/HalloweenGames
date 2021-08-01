using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {

    public float offset;

    public GameObject projectile;
    public GameObject shotEffect;
    public Transform shotPoint;
	
	
	public bool _shoot = false;
	
 

//	public AdsManager ads;  

	public Text ammoCounter;
	
	public int maxAmmo = 300;
	
	public int currentAmmo ;
	
	public float reloadTime= 1f;
	
	
    private float timeBtwShots;
    public float startTimeBtwShots;
	
	void Awake()
	{
	 
	}
	
	
	void Start()
	{
		currentAmmo = maxAmmo;
	//	mAudioSrc = GetComponent<AudioSource>();
	}
    private void Update()
    {
		Shoot();
	}
	
	 
	public void Shoot()
	{
		ammoCounter.text = currentAmmo.ToString();
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
		
		
 
        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0) && Time.timeScale != 0)
            {
			//	PostProcessingManager.instance.EnableEffect();
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
	 
