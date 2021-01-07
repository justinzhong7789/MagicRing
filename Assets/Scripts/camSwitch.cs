using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject thirdCam;
    public const int firstMode = 0, thirdMode = 1;
    public int camMode = 1;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("camera")){
            if(camMode == firstMode){
                camMode = thirdMode;
            }
            else if(camMode == thirdMode){
                camMode = firstMode;
            }
            StartCoroutine(CameraChange());
        }
    }

    IEnumerator CameraChange(){
        yield return new WaitForSeconds(0.01f);
        if(camMode == firstMode){
            firstCam.SetActive(true);
            thirdCam.SetActive(false);
        }
        if(camMode == thirdMode){
            thirdCam.SetActive(true);
            firstCam.SetActive(false);
            
        }
    }
}
