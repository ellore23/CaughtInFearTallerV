using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttyAnimationSetterClaustro : MonoBehaviour
{
    public Animator playerAnimator;
    void Awake()
    {
        playerAnimator = GameObject.Find("Atty(Clone)").GetComponent<Animator>();
        StartCoroutine(StartAnim());

    }

    // Update is called once per frame
    public IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(23);
        playerAnimator.SetBool("ClownScreamer1", true);
        yield return new WaitForSeconds(1.2f);
        playerAnimator.SetBool("ClownScreamer1", false);
        yield return new WaitForSeconds(16);
        playerAnimator.SetBool("ClownScreamer2", true);
        yield return new WaitForSeconds(1.2f);
        playerAnimator.SetBool("ClownScreamer2", false);



        yield return new WaitForSeconds(16);
        playerAnimator.SetBool("ClownScreamer3", true);
      




    }
}
