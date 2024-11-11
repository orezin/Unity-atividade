using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class rep7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> lista = new List<int>();

        lista.Add(1);
        lista.Add(2);
        lista.Add(3);
        lista.Add(4);
        lista.Add(5);
        lista.Add(6);
        lista.Add(7);

        int num = lista.Max();

        print(num);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
