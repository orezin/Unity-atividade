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
                print("Voc� coletou uma moeda!");
                break;
            case 1:
                print("Voc� coletou um power-up!");
                break;
            case 2:
                print("Voc� coletou uma po��o!");
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
