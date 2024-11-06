using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex11 : MonoBehaviour
{

    ex1 vida;

    
    // Start is called before the first frame update
    void Start()
    {

        string dialogo;
        vida = GameObject.FindGameObjectWithTag("Vida").GetComponent<ex1>();

        if (vida.VidaAtual < 50)
        {
            dialogo = "Rapaz, cê tá zoado, hein? De qualquer forma, vai querer levar algo?";
            print(dialogo);
        }

        else if (vida.VidaAtual < 20)
        {
            dialogo = "Cara, você precisa de um médico urgente! Posso te vender itens de cura!";
            print(dialogo);
        }

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
