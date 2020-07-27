using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escena2 : MonoBehaviour
{
    string palabra = " Expediciones \n\n Para empezar selecciona una de las tres expediciones a continuación: La expedición Botánica, La Comisión Corográfica y el Atlas Lingüinstico-Etnográfico de Colombia conocido como ALEC ";
    public Text texto;


    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in palabra)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }

    }
}
