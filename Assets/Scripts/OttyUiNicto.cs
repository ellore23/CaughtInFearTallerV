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

    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        animatorCont = GetComponent<Animator>();
        offset = transform.position - GameObject.Find("Atty").GetComponent<Transform>().position;
        StartCoroutine(StartAnim());
    }
    private void Update()
    {
        transform.position = GameObject.Find("Atty").GetComponent<Transform>().position + offset;
    }

    public IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(1);
        animatorCont.SetBool("Idle", true);
        yield return new WaitForSeconds(3);
        animatorCont.SetBool("Idle", false);
        animatorCont.SetBool("Oi1", true);
        var TextCR1 = Instantiate(Text1, (this.transform.position - new Vector3(0.7f,2.8f,1f)), Quaternion.identity);
        TextCR1.transform.SetParent(this.transform);
        yield return new WaitForSeconds(13);
        Destroy(TextCR1);
        animatorCont.SetBool("Oi2", true);
        var TextCR2 = Instantiate(Text2, (this.transform.position - new Vector3(0.7f, 2.8f, 1f)), Quaternion.identity);
        TextCR2.transform.SetParent(this.transform);
        yield return new WaitForSeconds(10);
        Destroy(TextCR2);
        animatorCont.SetBool("Oi3", true);
        var TextCR3 =Instantiate(Text3, (this.transform.position - new Vector3(0.7f, 2.8f, 1f)), Quaternion.identity);
        TextCR3.transform.SetParent(this.transform);
        yield return new WaitForSeconds(17);
        Destroy(TextCR3);
        animatorCont.SetBool("Idle", true);
        animatorCont.SetBool("Oi1", false);
        animatorCont.SetBool("Oi2", false);
        animatorCont.SetBool("Oi3", false);
        var TextCR4 = Instantiate(Text4, (this.transform.position - new Vector3(0.7f, 2.8f, 1f)), Quaternion.identity);
        TextCR4.transform.SetParent(this.transform);
        yield return new WaitForSeconds(10);
        Destroy (TextCR4);
        var TextCR5 = Instantiate(Text5, (this.transform.position - new Vector3(0.7f, 2.8f, 1f)), Quaternion.identity);
        TextCR5.transform.SetParent(this.transform);
        yield return new WaitForSeconds(2);
        Destroy(TextCR5);    

    }
}
