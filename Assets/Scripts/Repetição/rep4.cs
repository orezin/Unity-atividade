using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rep4 : MonoBehaviour
{
    stats mc;

    // Start is called before the first frame update
    void Start()
    {
        mc = GameObject.FindGameObjectWithTag("Mc").GetComponent<stats>();

        int pontos = mc.pontos;

        int hits = 0;
        int combo = 0;

        

        for (int i = 0; i <= 21; i++)
        {

            if (hits == 3)
            {
                combo += 1;
                hits = 0;
                mc.pontos += 10;
            }

            hits++;

        }

        print("Você deu um total de " + combo + " combos! " + mc.pontos + " pontos no total!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
