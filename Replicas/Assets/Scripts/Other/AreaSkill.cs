using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSkill : MonoBehaviour
{
    [SerializeField]
    private float absorbForce;

    private Rigidbody2D rb;

    [SerializeField]
    private bool isAbsorbing;

    [SerializeField]
    private SpriteRenderer player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==7)
        {
            isAbsorbing = true;
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            
        }

    }

    private void FixedUpdate()
    {
        if (isAbsorbing)
        {
            if (!player.flipX)
            {
                rb.velocity = new Vector2(-absorbForce, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(absorbForce, rb.velocity.y);
            }
            

        }


    }
}
