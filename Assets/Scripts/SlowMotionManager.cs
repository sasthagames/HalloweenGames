using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionManager : MonoBehaviour
{
	
	public static SlowMotionManager instance;
	
	void Awake()
	{
		instance = this;
	}
 
	public float slowdownFactor = 0.05f;
	public float slowdownLenght = 2f;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	//	Time.timeScale += (1f/slowdownLenght) * Time.unscaledDeltaTime;
	//	Time.timeScale = Mathf.Clamp(Time.timeScale,0f,1f);
		BacktoNormal();
    }
	public void BacktoNormal()
	{
		  Time.timeScale += (1f/slowdownLenght) * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp(Time.timeScale,0f,1f);
	}
	
	
	public void DoSlowMotion()
	{
		
		 Time.timeScale = slowdownFactor;
		 Time.fixedDeltaTime = Time.timeScale * .02f;
		
	}	
	
}


