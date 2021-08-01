using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Shop : MonoBehaviour
{

	public static Simple_Shop instance;
	public bool bulletawarded = false;
	public GameObject iapButton;

	
  
	public void Awake()
	{
		
		instance = this;

		
	}
	
    // Start is called before the first frame update
    void Start()
    {
     
    }
	
	public void PurchaseBundleAwarded()
	{
		if (bulletawarded)
		{
			Debug.Log("Function Entered");
			Debug.Log("PurchaseBundleAwarded"+bulletawarded);
			WeaponMultiple.instance.ShopReload();
			WeaponRailGun.instance.ShopReload();
		//  weaponMultiple.ShopReload();
		//  weaponRailGun.ShopReload();
		//	iapButton.SetActive(false);
		}
	
	}
	
	public void resetPlayerpref()
	{
		PlayerPrefs.DeleteAll();
	}
	

    // Update is called once per frame
    void Update()
    {
        
    }
}
