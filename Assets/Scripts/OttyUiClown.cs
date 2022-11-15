using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OttyUiClown : MonoBehaviour
{

    public Animator animatorCont;
    void Start()
    {
        animatorCont = GetComponent<Animator>();
        StartCoroutine(StartAnim());
    }

    public IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(1);
        animatorCont.SetBool("Idle", true);
        yield return new WaitForSeconds(3);
        animatorCont.SetBool("Oi1", true);
        yield return new WaitForSeconds(7);
        animatorCont.SetBool("Oi2", true);
        yield return new WaitForSeconds(8);
        animatorCont.SetBool("Oi3", true);
        yield return new WaitForSeconds(4);
        animatorCont.SetBool("Idle", true);
        animatorCont.SetBool("Oi1", false);
        animatorCont.SetBool("Oi2", false);
        animatorCont.SetBool("Oi3", false);


    }
}
