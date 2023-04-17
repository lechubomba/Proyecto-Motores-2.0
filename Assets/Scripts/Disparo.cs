using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform ControlDisparo;
    [SerializeField] private GameObject Bala1;
    //public GameObject BalaPrefab;

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            Disparar();
        
        }    
    }

    private void Disparar() 
    {
        GameObject Bala1 = Instantiate(Bala1, ControlDisparo.position, ControlDisparo.rotation);
        Bala1.GetComponent<Bala>().SetDirection();
    }
}
