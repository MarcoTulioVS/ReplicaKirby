using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    #region VARIABLES
    [Header("Animation")]
    [SerializeField]
    private PlayerAnimation _playerAnimation;

    private bool isReady;

    [Header("Particle")]
    [SerializeField]
    private GameObject particle;

    [Header("Collider")]
    [SerializeField]
    private Collider2D colliderSkill;

    [Header("Sound effect")]
    [SerializeField]
    private GameObject playerSound;

    #endregion
    void Start()
    {
        
    }

    void Update()
    {
        Absorb();
    }

    #region METHODS
    public void Absorb()
    {
        if (Input.GetKey(KeyCode.G))
        {
            particle.SetActive(true);
            colliderSkill.enabled = true;
            playerSound.SetActive(true);
            _playerAnimation.ExecuteAnimation(3);
            Player.isAttacking = true;
            
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            particle.SetActive(false);
            colliderSkill.enabled = false;
            playerSound.SetActive(false);
            Player.isAttacking = false;
        }
    }
    #endregion
}
