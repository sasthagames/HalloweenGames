using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTime : MonoBehaviour
{
	public static ForceTime instance;
	void Awake()
	{
		instance = this;
	}
	
    // Start is called before the first frame update
    void Start()
    {
      Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}