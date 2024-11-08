using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour {

    [SerializeField] float VidaInicial = 1f;
    public float VidaAtual;
    ex2 powerup;

    // Start is called before the first frame update
    void Start() {

        powerup = GameObject.FindGameObjectWithTag("Vida").GetComponent<ex2>();

        if (VidaAtual > 0) {
            print("O jogador está vivo!");
        }

        else if (VidaAtual <= 0) {
            if (powerup.PowerUP) {
                VidaAtual = VidaInicial / 2;
                print("Não! Você foi abençoado pelo Power UP!");
            }
        }

    }

    // Update is called once per frame
    void Update() {
        
    }
}
