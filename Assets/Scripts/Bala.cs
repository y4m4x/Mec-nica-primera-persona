using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public GameObject bala;
    public Transform spawnpoint;
    public UnityEngine.UI.Text KillCountUI;
    public int KillCount;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRatetime = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRatetime)
            {
                GameObject newbullet;

                newbullet = Instantiate(bala, spawnpoint.position, spawnpoint.rotation);

                newbullet.GetComponent<Rigidbody>().AddForce(spawnpoint.forward * shotForce);

                shotRatetime = Time.time + shotRate;

                Destroy(newbullet, 2);

            }
        }
    }
}
