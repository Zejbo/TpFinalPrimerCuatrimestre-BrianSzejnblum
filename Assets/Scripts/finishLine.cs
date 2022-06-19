using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour
{
    public bool perugaPorFavorAprobame = false;
    public GameObject monedas;
     void Update()
    {
        if(perugaPorFavorAprobame == true)
        {
            for(int i =0; i< 10; i++)
            {
                Instantiate(monedas, new Vector3(0, i, -286), Quaternion.identity);
                Debug.Log("Testing Ground");

            }
        }
        
    }
    private void OnCollisionEnter(Collision Pepe)
    {
        perugaPorFavorAprobame = true;
    }
}