using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{
    public static PlayerPowers instance;

    public GameObject power;
    private void Awake()
    {
        instance = this;
    }
    
}
