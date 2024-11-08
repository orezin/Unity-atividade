using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class rep3 : MonoBehaviour
{

    stats mc;

    

    // Start is called before the first frame update
    void Start()

    {

        mc = GameObject.FindGameObjectWithTag("Mc").GetComponent<stats>();

        int moedas = mc.moedas;

        for (int i = 1; i <= 10; i++)
        {

            print("Fase " + i + "! +3 moedas!");
            moedas += 3;

        }

        print(moedas + " moedas no total!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
