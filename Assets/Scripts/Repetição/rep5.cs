using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rep5 : MonoBehaviour
{

    [SerializeField] int pontosfase;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 6; i++)
        {
            pontosfase += 5;
            print(pontosfase + " pontos de nível de dificuldade da fase: " + i + "!");
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
