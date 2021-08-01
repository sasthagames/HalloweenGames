using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsAnimate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         onMoving();
    }
	public void onMoving()
	{
		transform.LeanMoveLocal(new Vector2(0,40),1).setEaseInOutSine().setLoopPingPong();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
