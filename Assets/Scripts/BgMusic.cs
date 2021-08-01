using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
	
	public static BgMusic bgmusic;
	
	void Awake()
	{
		if(bgmusic != null && bgmusic != this)
		{
			Destroy (this.gameObject);
			return;
		}
		bgmusic = this;
		DontDestroyOnLoad(this);
		
	}
    // Start is called before the first frame update
    void Start()
    {
      AudioSource audioSource = GetComponent<AudioSource>();
    audioSource.pitch = Random.Range(0.8f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
