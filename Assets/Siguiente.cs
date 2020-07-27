using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour
{
    
    public GameObject botonContinue;
    public GameObject botonContinue2;
    public GameObject botonQuitar;

    public GameObject panelDialogo;
    public GameObject panelDialogo1;
    public GameObject panelDialogo2;
    public GameObject panelDialogo3;

    public GameObject panelPri10y11;
    public GameObject panelDialogo10;
    public GameObject panelDialogo11;

    void Start()
    {
        panelDialogo.SetActive(true);
        panelDialogo1.SetActive(true);
        panelDialogo2.SetActive(false);
        panelDialogo3.SetActive(false);

        panelPri10y11.SetActive(false);
        panelDialogo10.SetActive(false);
        panelDialogo11.SetActive(false);

        //botonContinue.SetActive(true);
        botonContinue2.SetActive(false);
        botonQuitar.SetActive(false);


    }

    void Update()
    {
        botonContinue.SetActive(true);
    }
    
    public void ActivarSiguienteP()
    {
        botonContinue.SetActive(false);
        panelDialogo1.SetActive(false);
        panelDialogo2.SetActive(true);
        panelDialogo3.SetActive(false);

        panelPri10y11.SetActive(false);
        panelDialogo10.SetActive(false);
        panelDialogo11.SetActive(false);

        botonContinue2.SetActive(true);
        botonQuitar.SetActive(false);
    }

    public void ActivarSiguienteP3()
    {
        botonContinue.SetActive(false);
        botonContinue2.SetActive(false);
        panelDialogo1.SetActive(false);
        panelDialogo2.SetActive(false);
        panelDialogo3.SetActive(true);

        panelPri10y11.SetActive(false);
        panelDialogo10.SetActive(false);
        panelDialogo11.SetActive(false);

        botonQuitar.SetActive(true);
    }

    public void ActivarPanel10()
    {
        botonContinue.SetActive(false);
        botonContinue2.SetActive(true);
        panelDialogo1.SetActive(false);
        panelDialogo2.SetActive(false);
        panelDialogo3.SetActive(false);

        panelDialogo10.SetActive(true);
        panelDialogo11.SetActive(false);

        botonQuitar.SetActive(false);
    }

    public void ActivarPanel11()
    {
        botonContinue.SetActive(false);
        botonContinue2.SetActive(false);
        panelDialogo1.SetActive(false);
        panelDialogo2.SetActive(false);
        panelDialogo3.SetActive(false);

        panelDialogo10.SetActive(false);
        panelDialogo11.SetActive(true);

        botonQuitar.SetActive(false);
    }

    public void botonCerrar()
    {
        panelDialogo.SetActive(false);
        botonContinue.SetActive(false);
    }

    //public void Salir()
    //{
    //    print("Saliendo del juego ");
    //}
}
