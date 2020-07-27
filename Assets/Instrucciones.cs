using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
    string palabra = " Instrucciones: \n\n Tendrás 60 segundos para que encuentres las ilustraciones del listado en el mapa, con ayuda del visor. \n\n ¡Apresurate!  ";
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
