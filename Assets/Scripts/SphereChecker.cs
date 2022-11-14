using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Awake()
    {
        scriptAtty = GameObject.Find("Atty").GetComponent<PlayerMovement>();
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
            Instantiate(screamer, this.transform.position, Quaternion.identity);
            cont++;
            scriptAtty.animatorCont.SetBool("nictoAppeared", true);

        }

    }
}
