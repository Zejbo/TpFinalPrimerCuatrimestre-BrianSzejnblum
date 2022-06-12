using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    public int current;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision pepe)
    {

        if (pepe.collider.CompareTag("LowerPlayer"))
        {
            Destroy(gameObject);
        }
    }
}
