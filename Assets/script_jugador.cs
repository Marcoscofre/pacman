using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_jugador : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 15f;
    public float rotationSpeed = 720f;

    private void Awake(){
        rb = GetComponent<Rigidbody>();
    }
    void Start()
{
        Debug.Log("hola mundo");
    }

    // Update is called once per frame
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*speed,rb.velocity.y,moveVertical*speed);
        
        if(movement.magnitude > 0.1f){

            Quaternion targetRotation = Quaternion.LookRotation(movement);
            
            // Rotar el objeto gradualmente hacia la dirección del movimiento
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        rb.velocity = movement;
        //rb.velocity = movement * speed + new Vector3(0.0f, rb.velocity.y, 0.0f); // Mantener el eje Y (gravedad)
    }

     private void OnCollisionEnter(Collision collision)
        {
        if (collision.transform.CompareTag("punto")){
            Destroy(collision.gameObject);
        }
        }
}