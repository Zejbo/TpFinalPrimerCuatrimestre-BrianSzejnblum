﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccionDeCubo : MonoBehaviour
{
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

        if (pepe.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }

    }
}