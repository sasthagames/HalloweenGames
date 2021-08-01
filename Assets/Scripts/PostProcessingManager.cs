using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessingManager : MonoBehaviour
{
	public static PostProcessingManager instance;
	
	public void Awake()
	{
		instance = this;
	}

	public Volume volume;
	
	Bloom bloom;
	
	ChromaticAberration chromatic;
	
    // Start is called before the first frame update
    void Start()
    {
		volume.profile.TryGet<Bloom>(out bloom);
		volume.profile.TryGet<ChromaticAberration>(out chromatic);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		bloom.intensity.value = Mathf.PingPong(Time.time * 6,8f);
       EnableEffect();
    }
	
	public void EnableEffect()
	
	{
		 Debug.Log("EnableEffect");
		  
		chromatic.intensity.value = 0.39f;
	}
}
