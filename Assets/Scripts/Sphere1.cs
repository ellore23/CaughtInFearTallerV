using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere1 : MonoBehaviour
{
    public SphereChecker checker;

    private void Start()
    {
        checker = GameObject.Find("SphereChecker").GetComponent<SphereChecker>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        checker.cont++;
        Destroy(gameObject);
    }
}
