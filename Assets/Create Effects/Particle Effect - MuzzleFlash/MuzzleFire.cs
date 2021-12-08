using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFire : MonoBehaviour
{

    public ParticleSystem ParticleSystem;

    void Fire()
    {
        ParticleSystem.Play();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();  
        }
        
            
        
    }

   
}
