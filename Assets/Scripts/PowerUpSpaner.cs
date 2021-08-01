using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpaner : MonoBehaviour
{
	[SerializeField]
	public Transform[] PowerUpspawnPoints;
	public GameObject[] PowerUpenemyPrefab;
	public float PowerUprespawnTime = 3.0f;
	public static bool stopGame;
	public static bool reinitialised;
	public  static bool stopSpawn = false;
	public float timeDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(WaveGenerator());
				stopGame = false;
        reinitialised = false;
		stopSpawn = false;
      //  StartCoroutine(WaveGenerator());
		InvokeRepeating("SpawnPowerUpsTry",PowerUprespawnTime,timeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void SpawnPowerUps()
	{
		int randSpamPoint = Random.Range(0, PowerUpspawnPoints.Length);
		int randPowerup =  Random.Range(0, PowerUpenemyPrefab.Length);		
		Instantiate(PowerUpenemyPrefab[randPowerup],PowerUpspawnPoints[randSpamPoint].position,transform.rotation);
	}
	public void SpawnPowerUpsTry()
	{
		int randSpamPoint = Random.Range(0, PowerUpspawnPoints.Length);
		int randPowerup =  Random.Range(0, PowerUpenemyPrefab.Length);		
		Instantiate(PowerUpenemyPrefab[randPowerup],PowerUpspawnPoints[randSpamPoint].position,transform.rotation);
			if (stopSpawn == true)
		{
			Debug.Log ("CancelInvoke");
			CancelInvoke("SpawnPowerUpsTry");
		}
	}
	IEnumerator WaveGenerator()
	{
		while(true)
		{
			yield return new WaitForSeconds(PowerUprespawnTime);
			SpawnPowerUps();
		}
	}
}
