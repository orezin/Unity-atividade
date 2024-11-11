using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rep6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 1; i <= 10000; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                print("Fizz Buzz");
            }

            else if (i % 3 == 0)
            {
                print("Fizz");
            }

            else if (i % 5 == 0)
            {
                print("Buzz");
            }

            else
            {
                print(i);
            }


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
