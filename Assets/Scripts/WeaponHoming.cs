using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHoming : MonoBehaviour
{
	   public float offset;
	public Transform Target;
    public GameObject missile;
    public GameObject shotEffect;
    public Transform shotPoint;
	//private AudioSource mAudioSrc;
  //  public Animator camAnim;

    private float timeBtwShots;
    public float startTimeBtwShots;
    // Start is called before the first frame update
    void Start()
    {
//		Target = GameObject.FindGameObjectWithTag("Enemey").transform;
        
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
			//	mAudioSrc.Play();
             //   Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
               // camAnim.SetTrigger("shake");
			   SoundManager.PlaySound("playershoot");
                Instantiate(missile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
			//	 Target = GameObject.FindGameObjectWithTag("Enemey").transform;
				 
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
   
    }
}
