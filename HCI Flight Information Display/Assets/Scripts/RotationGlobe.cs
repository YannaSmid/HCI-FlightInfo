using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGlobe : MonoBehaviour
{
    public Transform Globe;
    public bool CanRotate = false;
    public float speed = 1;
    Vector3 DefaultRotation = new Vector3(0,0,0);
    // Start is called before the first frame update

    public void Update(){
        if (CanRotate){
            Globe.Rotate(0, 1f * Time.deltaTime * speed,0);
        }
    }
    public void StartRotation(){
        CanRotate = true;
    }

    public void StopRotation(){
        CanRotate = false;
    }
}
