using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex7 : MonoBehaviour
{

    [SerializeField] int faces;

    // Start is called before the first frame update
    void Start()
    {
        int result = Random.Range(1, faces);
        print("O resultado da rolagem foi " + result + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
