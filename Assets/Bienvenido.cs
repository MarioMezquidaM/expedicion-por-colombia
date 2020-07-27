using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bienvenido : MonoBehaviour
{
    string palabra = "¡Bienvenido! \n\n En esta actividad podrás viajar al pasado para explorar el territorio colombiano.Aprende a identificar las distintas especies de flora y fauna mientras recorres el territorio. ";
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
