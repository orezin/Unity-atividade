using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    [SerializeField] int frames;
    [SerializeField] int segundos;
    [SerializeField] int horas;
    [SerializeField] int dias;

    // Update is called once per frame
    void Update()
    {
        if (frames <= 60)
        {
            frames += 1;
        }

        if (frames == 60)
        {
            frames = 0;
            segundos += 1;
            print(dias + " dia(s)," + horas + "hora(s)" + segundos + "segundo(s)");
        }


        if (segundos == 10 && horas < 24)
        {
            segundos = 0;
            horas += 1;
        }

        if (horas == 24)
        {
            horas = 0;
            dias += 1;
        }
    }
}
