using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OttyUiNicto : MonoBehaviour
{
    public Animator animatorCont;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;    
    public GameObject Text5;
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
        animatorCont.SetBool("Idle", false);
        animatorCont.SetBool("Oi1", true);
        var TextCR1 = Instantiate(Text1, new Vector3(0.26f, -3.05f,-1f), Quaternion.identity);
        yield return new WaitForSeconds(13);
        Destroy(TextCR1);
        animatorCont.SetBool("Oi2", true);
        var TextCR2 = Instantiate(Text2, new Vector3(0.26f, -3.05f, -1f), Quaternion.identity);
        yield return new WaitForSeconds(10);
        Destroy(TextCR2);
        animatorCont.SetBool("Oi3", true);
        var TextCR3 =Instantiate(Text3, new Vector3(0.26f, -3.05f, -1f), Quaternion.identity);
        yield return new WaitForSeconds(17);
        Destroy(TextCR3);
        animatorCont.SetBool("Idle", true);
        animatorCont.SetBool("Oi1", false);
        animatorCont.SetBool("Oi2", false);
        animatorCont.SetBool("Oi3", false);
        var TextCR4 = Instantiate(Text4, new Vector3(0.26f, -3.05f, -1f), Quaternion.identity);
        yield return new WaitForSeconds(10);
        Destroy (TextCR4);
        var TextCR5 = Instantiate(Text5, new Vector3(0.26f, -3.05f, -1f), Quaternion.identity);
        yield return new WaitForSeconds(2);
        Destroy(TextCR5);
        




    }
}
