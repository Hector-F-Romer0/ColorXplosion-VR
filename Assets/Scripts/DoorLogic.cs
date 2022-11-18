using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    GameObject[] greenDoors;
    GameObject[] orangeDoors;

    // Start is called before the first frame update
    void Start()
    {
        greenDoors = GameObject.FindGameObjectsWithTag("doorgreen");
        orangeDoors = GameObject.FindGameObjectsWithTag("doororange");
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject gd in greenDoors){

            if (Input.GetKeyDown(KeyCode.A)){
            
            if (gd.activeSelf){

                gd.SetActive(false);

            }else{

                gd.SetActive(true);

            }

            }
        }

        foreach(GameObject od in orangeDoors){

            if (Input.GetKeyDown(KeyCode.S)){
            
            if (od.activeSelf){

                od.SetActive(false);

            }else{

                od.SetActive(true);

            }

            }
        }
        
    }
}
