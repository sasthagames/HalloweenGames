using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ShadowEffect : MonoBehaviour
{
	
	GameObject _shadow;
	
	public Material Material;
	
	public  Vector3 Offset = new Vector3(-0.1f,-0.1f);
	
    // Start is called before the first frame update
    void Start()
    {
		var _shadow = new GameObject ("Shadow");
		
		_shadow.transform.parent = transform;
		
		_shadow.transform.localPosition = Offset;
		
		_shadow.transform.localRotation = Quaternion.identity;
		
		SpriteRenderer renderer = GetComponent <SpriteRenderer>();
		SpriteRenderer sr = _shadow.AddComponent<SpriteRenderer>();
		sr.sprite = renderer.sprite;
		sr.material = Material;
		
		sr.sortingLayerName = renderer.sortingLayerName;
		sr.sortingOrder = renderer.sortingOrder -1;
		
		
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _shadow.transform.localPosition = Offset;
    }
}
