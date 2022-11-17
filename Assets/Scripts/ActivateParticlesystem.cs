using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParticlesystem : MonoBehaviour
{
    public GameObject Bola;

    private void OnCollisionEnter2D(Collision2D collisionm)
    {
        if(collisionm.gameObject.tag=="Player")
        {
            Bola.SetActive(true);
        }
    }
}
