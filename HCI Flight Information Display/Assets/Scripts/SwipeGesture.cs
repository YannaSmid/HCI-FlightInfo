using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeGesture : MonoBehaviour
{

    public GameObject LeapHandModels;
    public GameObject Globe;

    public Collider TriggerZone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay (Collider other)
    {
        
            Debug.Log("Triggered");
       
    }

}
