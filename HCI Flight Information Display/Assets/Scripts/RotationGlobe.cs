using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGlobe : MonoBehaviour
{
    bool startProgram = true;
    //Handmodels
    public GameObject LeftHand;
    Transform HandPalm;
    Vector3 HandposNew;
    Vector3 HandposOld;
    Vector3 HandposDiff;
    float HandposDiffx;

    //earth
    public Transform Globe;
    public bool CanRotate = false;
    public float speed = 1;
    Vector3 DefaultRotation = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start(){
       
       
    }

    public void Update(){
        
        if (startProgram)
        {
            HandPalm = LeftHand.transform.GetChild(0);
            //Debug.Log(HandPalm.name);
            HandposNew = HandPalm.position;
            startProgram = false;
        }

        HandposOld = HandposNew;
        Debug.Log(HandposOld + "en" + HandposNew);
        HandposNew = HandPalm.position;
        if (CanRotate){
            HandposDiff = HandposOld - HandposOld;
            HandposDiffx = HandposNew.x * 100f;
            //Debug.Log(HandposDiffx);
            Globe.Rotate(0, 1f * Time.deltaTime * speed * HandposDiffx,0);
        }
    }
    public void StartRotation(){
        CanRotate = true;
    }

    public void StopRotation(){
        CanRotate = false;
    }
}
