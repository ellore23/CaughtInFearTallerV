using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSetter : MonoBehaviour
{
    public GameObject fondo;
    public GameObject animacionInicial;
    public Animator nicto;
    
   
    private void Awake()
    {
        nicto = GameObject.Find("Animation").GetComponent<Animator>();
        fondo.SetActive(false);
        animacionInicial.SetActive(true);
    }

    private void Update()
    {
        EndInitialAnim();
       
    }
    private void EndInitialAnim()
    {
        if (nicto.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !nicto.IsInTransition(0))
        {
            fondo.SetActive(true);
            animacionInicial.SetActive(false);
        }
       
    }

}
