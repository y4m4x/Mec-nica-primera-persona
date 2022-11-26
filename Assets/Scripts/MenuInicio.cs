using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    // Start is called before the first frame update
    public void Inicio()
    {
        SceneManager.LoadScene("Escena1");
    }

    public void Cerrar()
    {
        Application.Quit();
    }
}

