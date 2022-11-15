using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereChecker : MonoBehaviour
{
    public int cont;
    public GameObject Nicto1;
    public GameObject Nicto2;
    public GameObject Nicto3;
    public GameObject target;
    public PlayerMovement scriptAtty;

    public Vector3 offset;
    public GameObject screamer;

    public Camera maincamera;
    public Camera secondcamera;
    public GameObject AttyFall;
    public GameObject OttyUi;

    public ParticleSystem morado;
    public ParticleSystem verde;
    public ParticleSystem azul;

    private void Start()
    {
        scriptAtty = GameObject.Find("Atty").GetComponent<PlayerMovement>();
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        secondcamera = GameObject.Find("Second camera").GetComponent<Camera>();
        maincamera.enabled = true;
        secondcamera.enabled = false;
        StartCoroutine(MoveAtty());
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 1)
        {           
            Nicto1.transform.position = target.transform.position + new Vector3(-3f, 3.5f, 0);
        } 
        else if (cont == 2)
        {
            Nicto1.transform.position = target.transform.position + new Vector3(-3f, 3.5f, 0);
            Nicto2.transform.position = target.transform.position + new Vector3(-3.2f, 1f, 0);
            Nicto3.transform.position = target.transform.position + new Vector3(-2.0f, 2f, 0);
        }
        else if (cont == 3)
        {
            Instantiate(screamer, new Vector3(104.120003f, 0.00739991665f, -1.01943612f), Quaternion.identity);
            cont++;
            scriptAtty.animatorCont.SetBool("nictoAppeared", true);
            StartCoroutine(AttyFalling());

        }

    }

    public IEnumerator AttyFalling()
    {
        yield return new WaitForSeconds(1);
        maincamera.enabled = false;
        secondcamera.enabled =true;
        secondcamera.gameObject.transform.position = new Vector3(145.93f, -0.03f, 0f);
        Instantiate(AttyFall, new Vector3(145.93f, 0f, 1f), Quaternion.identity);
        morado.Play();
        verde.Play();
        azul.Play();
        PhobiaSelectionObjDetector.Clicprop3 = true;
        PhobiaSelectionObjDetector.propCount++;
        yield return new WaitForSeconds(1.5f);
        if (PhobiaSelectionObjDetector.propCount > 2)
        {
            SceneManager.LoadScene("Ending");
        }
        else
        {
            SceneManager.LoadScene("PhobiaSelectionNoVideo");
        }
    }

    public IEnumerator MoveAtty()
    {
        yield return null;
        scriptAtty.gameObject.transform.position = new Vector3(-13.4399996f, -0.970000029f, -1f);
        yield return new WaitForSeconds(1.7f);
        scriptAtty.gameObject.transform.position = new Vector3(-3.83999991f, -0.970000029f, -1f);
        Instantiate(OttyUi, new Vector3(2.33f, -0.922557473f, -1f), Quaternion.identity);



    }
}
