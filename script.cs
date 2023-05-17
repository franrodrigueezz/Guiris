using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public GameObject BotonEmpezar;
    public GameObject BotonSalir;
    public GameObject PanelInicio;
    public GameObject Panel1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void salir()
    {
        Application.Quit();
    }
    public void jugar()
    {
        Panel1.SetActive(true);
        PanelInicio.SetActive(false);
    }
}
