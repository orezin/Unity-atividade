using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex9 : MonoBehaviour
{

    [SerializeField] int A;
    [SerializeField] int B;

    // Start is called before the first frame update
    void Start()
    {
        if (A > B)
        {
            print("O time A foi o vencedor!");
        }

        else if (B > A)
        {
            print("O time B foi o vencedor!");
        }

        else if (A == B && A + B < 6) {
            print("Houve um empate entre os times!");

        }

        else if (A == B && A + B >= 6)
        {
            print("Houve um empate EMOCIONANTE entre os times!");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
