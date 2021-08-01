using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParent : MonoBehaviour
{
	public float lifeTime;
   void Start()
   {
	   Invoke("DestroyTrail", lifeTime);
   }
  
  public void DestroyTrail()
  {
	    Destroy(transform.parent.gameObject); 
  }
}
