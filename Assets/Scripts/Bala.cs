using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Bala1 : MonoBehaviour
{

    public float Speed = 5.0f; 
    public Rigidbody Rigidbody;
    private Vector2 Direction;
    
    
    void Start() 
    {
        Rigidbody = GetComponent<Rigidbody>();
    
    }

    void FixedUpdate()
    {
        Rigidbody.velocity = Direction * Speed;

        //transform.Translate(Vector2.up * Speed * Time.deltaTime);
        
    }

    public void SetDirection(Vector2 direction) 
    { 
     Direction=direction;
    
    
    }

    

}

