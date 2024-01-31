using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            playerMovement._isJumping = false;
        }

        if (collision.gameObject.layer==7)
        {
            if (Player.isAttacking)
            {
                collision.gameObject.SetActive(false);
                collision.gameObject.GetComponent<PlayerPowers>().power.SetActive(true);
            }
        }
    }
}
