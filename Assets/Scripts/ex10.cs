using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex10 : MonoBehaviour
{

    [SerializeField] int item;

    // Star is called before the first frame update
    void Start()
    {
        switch (item)
        {
            case 0:
                print("Você coletou uma moeda!");
                break;
            case 1:
                print("Você coletou um power-up!");
                break;
            case 2:
                print("Você coletou uma poção!");
                break;
            default:
                print("Item desconhecido!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
