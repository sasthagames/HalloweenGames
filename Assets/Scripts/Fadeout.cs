using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeout : MonoBehaviour
{
	SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
		
    }
	IEnumerator FadeOut()
		{
			for (float f = 1f ; f > -0.05f ; f = 0.05f)
			{
				Color c = rend.material.color;
				c.a = f;
				rend.material.color = c;
				yield return new WaitForSeconds(0.05f);
			}	
		}
	public void StartFading()
	{
		StartCoroutine("FadeOut");
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
