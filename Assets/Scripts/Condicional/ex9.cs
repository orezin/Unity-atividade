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

        else
        {
            if (B > 3 && A > 3)
            {
                print("Foi um EMPATE emocionante!");
            }

            else
            {
                print("Foi um empate!");
            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
