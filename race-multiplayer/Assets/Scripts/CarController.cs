using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField]Rigidbody sphereRB;

    private void Awake()
    {
        sphereRB = GetComponentInChildren<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //passando a posicao do carro para a posicao da esfera
        transform.position = sphereRB.transform.position;
    }
}
