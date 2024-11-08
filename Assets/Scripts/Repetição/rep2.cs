using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class rep2 : MonoBehaviour
{
    stats mc;

    // Start is called before the first frame update
    async void Start()
    {
        mc = GameObject.FindGameObjectWithTag("Mc").GetComponent<stats>();
        int dano = mc.dano;


        for (int i = 5; i > 0; i--)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            dano += 2;

            print("Seu dano aumentou para " + "!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
