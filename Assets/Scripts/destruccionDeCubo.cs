using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccionDeCubo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject moneda ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision pepe)
    { 
      
        if (pepe.collider.CompareTag("Upperplayer"))
        {
         Destroy(gameObject)   ;
            Instantiate(moneda,transform.position,Quaternion.identity);
        }
    }
}
