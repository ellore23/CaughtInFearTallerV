using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prop1;
    public GameObject prop2;
    public GameObject prop3;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;

    Vector3 coord1;
    Vector3 coord2;
    Vector3 coord3;

    int posiciones;
    int randomizer;

    void Start(){
        coord1 = pos1.transform.position;
        coord2 = pos2.transform.position;
        coord3 = pos3.transform.position;        

        Randomizing();
    }

    void Randomizing(){
        randomizer = Random.Range(1,6);

        if(randomizer == 1){

            Instantiate(prop1, coord1, Quaternion.identity);
            Instantiate(prop2, coord2, Quaternion.identity);
            Instantiate(prop3, coord3, Quaternion.identity);
        }
        else if(randomizer == 2){

            Instantiate(prop1, coord1, Quaternion.identity);
            Instantiate(prop2, coord3, Quaternion.identity);
            Instantiate(prop3, coord2, Quaternion.identity);
        }
        else if(randomizer == 3){

            Instantiate(prop1, coord2, Quaternion.identity);
            Instantiate(prop2, coord1, Quaternion.identity);
            Instantiate(prop3, coord3, Quaternion.identity);
        }
        else if(randomizer == 4){

            Instantiate(prop1, coord2, Quaternion.identity);
            Instantiate(prop2, coord3, Quaternion.identity);
            Instantiate(prop3, coord1, Quaternion.identity);
        }
        else if(randomizer == 5){

            Instantiate(prop1, coord3, Quaternion.identity);
            Instantiate(prop2, coord1, Quaternion.identity);
            Instantiate(prop3, coord2, Quaternion.identity);
        }
        else{

            Instantiate(prop1, coord3, Quaternion.identity);
            Instantiate(prop2, coord2, Quaternion.identity);
            Instantiate(prop3, coord1, Quaternion.identity);
        }
        
    }

}
