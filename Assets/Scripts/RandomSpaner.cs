using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpaner : MonoBehaviour
{
	[SerializeField]
	public Transform[] spawnPoints;
	public GameObject[] enemyPrefab;
	public float respawnTime = 1.0f;
	public static bool stopGame;
	public static bool reinitialised;
	public  static bool stopSpawn = false;
	public float timeDelay = 1.0f;
 
    // Start is called before the first frame update
    void Start()
    {
		stopGame = false;
        reinitialised = false;
		stopSpawn = false;
      //  StartCoroutine(WaveGenerator());
		InvokeRepeating("SpawnEnemies",respawnTime,timeDelay);
		
    }

    // Update is called once per frame
    void Update()
    {
	
 
	 
    }
	
 
	public void SpawnEnemies()
	{
		int randSpamPoint = Random.Range(0, spawnPoints.Length);
		int randEnemy =  Random.Range(0, enemyPrefab.Length);		
		Instantiate(enemyPrefab[randEnemy],spawnPoints[randSpamPoint].position,transform.rotation);
		if (stopSpawn == true)
		{
			Debug.Log ("CancelInvoke");
			CancelInvoke("SpawnEnemies");
		}
	}
 
		
	 
}
