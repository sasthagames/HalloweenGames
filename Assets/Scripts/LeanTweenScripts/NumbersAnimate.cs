using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersAnimate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tween();
    }
	public void Tween()
	{
		 transform.LeanScale(Vector2.zero,1f).setEaseInBack();
	//	LeanTween.scale(gameObject,Vector3.one *2,tweenTime).setEasePunch();
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
