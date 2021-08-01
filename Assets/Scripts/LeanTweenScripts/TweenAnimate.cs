using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenAnimate : MonoBehaviour
{
	public Transform box;
	private void OnEnable()
	{
		 
		
		box.localPosition = new Vector2(0,-Screen.height);
		box.LeanMoveLocalY(0,0.5f).setEaseOutExpo().delay = 0.01f;
	}
	public void CloseDialog()
	{
		
		box.LeanMoveLocalY(-Screen.height,0.5f).setEaseInExpo().setOnComplete(OnComplete);
		
	}
	void OnComplete()
	{
		gameObject.SetActive(false);
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
