using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class WeaponHoming : MonoBehaviour
{
	   public float offset;
	public Transform Target;
    public GameObject missile;
    public GameObject shotEffect;
    public Transform shotPoint;


    private float timeBtwShots;
    public float startTimeBtwShots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
				
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
		
			    SoundManager.PlaySound("playershoot");
			   
                Instantiate(missile, shotPoint.position, transform.rotation);
				
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
