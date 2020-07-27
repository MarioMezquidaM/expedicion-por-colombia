using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escena10 : MonoBehaviour
{
    string palabra = " ¡Se acabó el tiempo! \n\n ¡Felicitaciones! ¡Lo lograste en el tiempo acordado! \n ¿Quieres aventurarte en una nueva expedición? ";
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
