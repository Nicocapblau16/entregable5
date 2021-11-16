using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 100.0f;
    private float verticalInput;
    private float zMax = 450.0f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero; //pos inicial
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //movimiento hacia adelante constante
        

        verticalInput = Input.GetAxis("Vertical"); //pulsar w o (flecha arriba)
        
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * -verticalInput); //rotacion (x)         

        if (transform.position.z >= zMax) //final juego
        {
            Debug.Log("The END");
            Time.timeScale = 0;
        }
    }
}
