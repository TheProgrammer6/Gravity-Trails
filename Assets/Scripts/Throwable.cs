﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public Text collectableCounter;
    public int throwableCounter;
    public GameObject objectThrown;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            offset = transform.localScale.x * new Vector3 (1,0,0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition , transform.rotation);
          
        }
       
    }
}
