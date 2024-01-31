using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region VARIABLES

    [Header("Movement")]

    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody2D _rb;

    private float _movement;

    [SerializeField]
    private float _jumpForce;

    [Header("Animation")]
    [SerializeField]
    private PlayerAnimation _playerAnimation;

    
    [HideInInspector]
    public bool _isJumping;

    [Header("Size")]
    [SerializeField]
    private float increaseSize;

    [Header("Sprite")]
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    #endregion
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Jump();
    }

    #region METHODS
    public void Move()
    {
        _movement = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_speed * _movement, _rb.velocity.y);

        if (_movement > 0)
        {

            spriteRenderer.flipX = false;
            _playerAnimation.ExecuteAnimation(1);
        }
        else if(_movement < 0)
        {

            spriteRenderer.flipX = true;
            _playerAnimation.ExecuteAnimation(1);
        }
        else if(!_isJumping && !Player.isAttacking)
        {
            _playerAnimation.ExecuteAnimation(0);
        }
        
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            
            _isJumping = true;
            _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            _playerAnimation.ExecuteAnimation(2);
            SoundController.instance.PlaySound(SoundController.instance.audios[0]);
        }

        if (_isJumping)
        {
            transform.localScale = Vector3.one * increaseSize;
        }
        else
        {
            transform.localScale = Vector3.one;
        }
    }

    #endregion
}
