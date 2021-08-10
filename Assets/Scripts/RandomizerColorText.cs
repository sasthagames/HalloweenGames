using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizerColorText : MonoBehaviour
{
	
	public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),1);
    }

 }
