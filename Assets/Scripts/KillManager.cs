using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillManager : MonoBehaviour
{
	public static KillManager instance;
	
	private void Awake()
	{
		instance = this;
	}
	
	public GameObject FirstBlood;
	public GameObject twentyfifthBlood;
	public GameObject halfcenturyBlood;
	public GameObject CenturyBlood;
	public GameObject OneFiftyBlood;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	 public void FirstKill()
	 {
		 FirstBlood.SetActive(true);
	 }
	 	 public void twentyfifthKill()
	 {
		 twentyfifthBlood.SetActive(true);
	 }
	 	 public void halfcenturyKill()
	 {
		 halfcenturyBlood.SetActive(true);
	 }
	 	 public void CenturyKill()
	 {
		 CenturyBlood.SetActive(true);
	 }
	 	 public void OneFiftyKill()
	 {
		 OneFiftyBlood.SetActive(true);
	 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
