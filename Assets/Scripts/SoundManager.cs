using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playershootSound,rocketshootSound,gameOverScoreSound,killsScoreSound,bullettimeSound,bulletemptySound, enemyDiegroundSound, enemyDieBulletSound, gameOverSound, powerupSound,achievementSound;
    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        audioScr = GetComponent<AudioSource>();
        playershootSound = Resources.Load<AudioClip>("playershoot");
		rocketshootSound = Resources.Load<AudioClip>("homingmissile");
		gameOverScoreSound = Resources.Load<AudioClip>("whoosh");
		killsScoreSound = Resources.Load<AudioClip>("whoosh_fast");
		bullettimeSound = Resources.Load<AudioClip>("bullettime");	
		bulletemptySound = Resources.Load<AudioClip>("bulletemptytime");	
        enemyDiegroundSound = Resources.Load<AudioClip>("enemyDieground");
        enemyDieBulletSound = Resources.Load<AudioClip>("enemyDieBullet");
        gameOverSound = Resources.Load<AudioClip>("gameOver");
		powerupSound = Resources.Load<AudioClip>("powerup");
		achievementSound = Resources.Load<AudioClip>("achievement");
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
				case "homingmissile":
                audioScr.PlayOneShot(rocketshootSound);
                break;
				case "playershoot":
                audioScr.PlayOneShot(playershootSound);
                break;
				case "bullettime":
                audioScr.PlayOneShot(bullettimeSound);
                break;
				case "bulletemptytime":
                audioScr.PlayOneShot(bulletemptySound);
                break;
				case "enemyDieground":
                audioScr.PlayOneShot(enemyDiegroundSound);
                break;
				case "enemyDieBullet":
                audioScr.PlayOneShot(enemyDieBulletSound);
                break;
				case "gameOver":
                audioScr.PlayOneShot(gameOverSound);
                break;
				case "powerup":
                audioScr.PlayOneShot( powerupSound );
                break;
				case "achievement":
                audioScr.PlayOneShot( achievementSound );
                break;
				case "whoosh":
                audioScr.PlayOneShot( gameOverScoreSound );
                break;
				case "whoosh_fast":
                audioScr.PlayOneShot( killsScoreSound );
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
