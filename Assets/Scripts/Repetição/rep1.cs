using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using UnityEngine;

public class rep1 : MonoBehaviour
{

    // Start is called before the first frame update

    async void Start()
    {

        for (int i = 5; i > 0; i--)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            print(i);
        }

        print("Início da partida!");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
