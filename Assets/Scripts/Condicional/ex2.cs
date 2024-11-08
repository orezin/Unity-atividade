using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour {

    public bool PowerUP = false;
    
    // Start is called before the first frame update
    void Start() {

        string powercheck = PowerUP ? "PowerUP ativado!" : "PowerUP desativado!";

        print(powercheck);
    
    }

    // Update is called once per frame
    void Update() {
        
    }
}
