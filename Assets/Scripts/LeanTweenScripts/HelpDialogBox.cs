using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpDialogBox : MonoBehaviour
{
	public Transform box;
	public CanvasGroup background;
	private void OnEnable()
	{
		background.alpha = 0;
		background.LeanAlpha(0.5f,0.5f);
		
		box.localPosition = new Vector2(0,-Screen.height);
		box.LeanMoveLocalY(0,0.5f).setEaseOutExpo().delay = 0.04f;
	}
	public void CloseDialog()
	{
		background.LeanAlpha(0,0.5f);
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
