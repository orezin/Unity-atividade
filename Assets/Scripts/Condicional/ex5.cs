using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{

    [SerializeField] int pontos;


    // Start is called before the first frame update
    void Start()
    {

        string success = pontos >= 50 ? "Miss�o bem-sucedida!" : "Miss�o incompleta!";

        print("Voc� atingiu um total de " + pontos + " pontos! " + success);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
