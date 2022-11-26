using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Debug.Log("Enemy get shooted");



            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            SceneManager.LoadScene("Victoria");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
