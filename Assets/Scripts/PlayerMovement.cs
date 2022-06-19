using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject coins;
    public Text textoDeVidas, timer, TextoMonedas;
    public AudioClip sonidoDeSaltar;
    AudioSource fuenteAudio;
    public float movementSpeed, fuerzaDeSalto, tiempo = 150;
    public Rigidbody rb;
    public int cuboEstaEnElPiso = 2, monedas = 0;
    public int vidas = 3, victoria = 0;
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
        TextoMonedas.text = "Tenes " + monedas + " Monedas";
        tiempo -= Time.deltaTime;
        timer.text = tiempo.ToString("f0");
        textoDeVidas.text = ("Tenes " + vidas + " Vidas");
        if (vidas == 0 || tiempo == 0)
        {
            Destroy(gameObject);
            textoDeVidas.text = "Perdiste";
        }
        if (victoria == 1)
        {
            Destroy(gameObject);
            textoDeVidas.text = "Ganaste";
            tiempo = 1000000000;
            for (int i = 0; i < 6; i++)
            {
                Instantiate(coins, transform.position, Quaternion.identity) ; 

            }
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
        if (Pepe.gameObject.name == "FinishLine")
        {
            victoria = 1;
        }
        if (Pepe.gameObject.tag == "Moneda")
        {
            monedas++;
            
            


        }

    }
}
