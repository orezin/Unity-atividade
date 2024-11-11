using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class rep8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string word = "Cachorro";

        string final = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            char letra = word[i];

            string letrastring = letra.ToString();

            final += letrastring;
            
        }

        print(final);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
