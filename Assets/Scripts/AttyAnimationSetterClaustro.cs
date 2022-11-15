using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttyAnimationSetterClaustro : MonoBehaviour
{
    public Animator playerAnimator;
    void Start()
    {
        playerAnimator = GameObject.Find("Atty").GetComponent<Animator>();
        StartCoroutine(StartAnim());

    }

    // Update is called once per frame
    public IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(3);
        playerAnimator.SetBool("ClownScreamer1", true);
        yield return new WaitForSeconds(1.2f);
        playerAnimator.SetBool("ClownScreamer1", false);
        
       


    }
}
