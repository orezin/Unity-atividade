using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    ex1 vida;

    [SerializeField] int LifePotion = 0;

    // Start is called before the first frame update
    void Start()
    {

        vida = GameObject.FindGameObjectWithTag("Vida").GetComponent<ex1>();

        float checklife = vida.VidaAtual;

        if (checklife >= 1)
        {
            if (LifePotion >= 1)
            {
                LifePotion -= 1;

                vida.VidaAtual += 50;

                print("Você usou uma poção de vida! (+50 de HP)!");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
