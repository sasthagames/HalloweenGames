using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        onMoving();
    }
	public void onMoving()
	{
		transform.LeanMoveLocal(new Vector2(0,40),2).setEaseOutQuart().setLoopPingPong();
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
