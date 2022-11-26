using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    // Start is called before the first frame update
    public void VolverMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    public void JugarDeNuevo()
    {
        SceneManager.LoadScene("Escena1");
    }
}
