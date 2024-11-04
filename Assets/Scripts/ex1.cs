using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour {

    [SerializeField] float Vida = 1f;
    ex2 powerup;

    // Start is called before the first frame update
    void Start() {

        powerup = GameObject.FindGameObjectWithTag("Vida").GetComponent<ex2>();

        
        if (Vida > 0) {
            print("O jogador está vivo!");
        }

        else if (Vida <= 0) {
            if (powerup.PowerUP) {
                Vida = 10.0f;
                print("Não! Você foi abençoado pelo Power UP!");
            }
        }

    }

    // Update is called once per frame
    void Update() {
        
    }
}
