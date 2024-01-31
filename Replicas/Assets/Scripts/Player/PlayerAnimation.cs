using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    public void ExecuteAnimation(int value)
    {
        anim.SetInteger("transition",value);
    }
}
