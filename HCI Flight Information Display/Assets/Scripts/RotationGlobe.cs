using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGlobe : MonoBehaviour
{
    public Transform Globe;

    public float speed = 1;
    Vector3 DefaultRotation = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotation(){
        Globe.Rotate(0, 1f * Time.deltaTime * speed,0);
    }
}
