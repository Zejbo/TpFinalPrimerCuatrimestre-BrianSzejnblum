using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioClip sonidoDeSaltar;
    AudioSource fuenteAudio;
    public float movementSpeed,fuerzaDeSalto ;
    public Rigidbody rb;
     public int cuboEstaEnElPiso = 2;
    public int vidas = 3;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vidas == 0)
            {
            Destroy(gameObject);
        }

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
            fuenteAudio.clip = sonidoDeSaltar;
            fuenteAudio.Play();
            
        }
    }
    private void OnCollisionEnter(Collision Pepe)
    {
        if (Pepe.gameObject.tag == "Bloque" || Pepe.gameObject.tag == "Plataforma")
        {
            cuboEstaEnElPiso = 2;
        }
        if (Pepe.gameObject.tag == "enemigo" || Pepe.gameObject.name == "pisoDeLaMuerte")
        {
            vidas--;
            transform.position = startPosition;
            
        }
        


    }
}
