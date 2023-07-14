using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    int Health = 3;
    float IFrames = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (IFrames > 0f)
        {
            IFrames -= Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pete") && IFrames <= 0)
        {
            IFrames = 3;
            Debug.Log("Hit");
            if (Health > 1)
            {
                Health -= 1;
                Debug.Log(Health);
            }
            else
            {
                Debug.Log("Death");
            }
        }
    }
}
