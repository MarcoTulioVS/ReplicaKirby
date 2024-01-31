using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    [SerializeField]
    private float time;

    private bool isReady;
    private void OnEnable()
    {
        StartCoroutine("TimePower");
    }

    private void OnDisable()
    {
        StopCoroutine("TimePower");
    }

    IEnumerator TimePower()
    {
        if (!isReady)
        {
            
            isReady = true;
            yield return new WaitForSeconds(time);
            gameObject.SetActive(false);
            isReady = false;
            
        }
        

    }
}
