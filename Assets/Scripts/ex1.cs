using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour {

    [SerializeField] float Vida = 1;
   

    // Start is called before the first frame update
    void Start() {

        string alivecheck = Vida > 0 ? "O jogador est� vivo." : "O jogador est� morto.";

        print(alivecheck);

    }

    // Update is called once per frame
    void Update() {
        
    }
}
