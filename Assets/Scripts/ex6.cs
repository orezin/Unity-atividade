using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ex6 : MonoBehaviour
{
    [SerializeField] int classe;


    // Start is called before the first frame update
    void Start()
    {
        switch (classe)
        {
            case 0:
                print("Voc� escolheu a classe Guerreiro!");
                break;
            case 1:
                print("Voc� escolheu a classe Mago!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
