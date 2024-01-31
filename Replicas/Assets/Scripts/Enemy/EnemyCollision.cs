using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject projectile;

    private bool isReady;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="power" )
        {
            SoundController.instance.PlaySound(SoundController.instance.audios[1]);
            StartCoroutine("ActiveParticleEffect");
        }
    }

    IEnumerator ActiveParticleEffect()
    {
        if (!isReady)
        {
            isReady = true;
            projectile.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            projectile.SetActive(false);
            gameObject.SetActive(false);
            isReady = false;
        }
        

    }

}
