using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSetter : MonoBehaviour
{
    public GameObject fondo;
    public GameObject animacionInicial;

    private void Awake()
    {
        fondo.SetActive(false);
        animacionInicial.SetActive(true);
    }

}
