using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed,fuerzaDeSalto ;
    public Rigidbody rb;
     public int cuboEstaEnElPiso = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.A))
        {
            // transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, movementSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetButtonDown("Jump") && cuboEstaEnElPiso > 0)
        {    
            rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            cuboEstaEnElPiso--;
        
            
        }
    }
    private void OnCollisionEnter(Collision Pepe)
    {
        if (Pepe.gameObject.name == "Piso")
        {
            cuboEstaEnElPiso = 2;
        }
    }
}
