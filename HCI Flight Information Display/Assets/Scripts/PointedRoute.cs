using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointedRoute : MonoBehaviour
{
    public Object Route;
    public GameObject FlightInfo;
    public Color SelectedColor;
    public Color DefaultColor;
    public Renderer RouteRenderer;
    public bool pointed = false;

    private bool selected = false;

    private float countdown;
    public float pointtime = 5f;
    // Start is called before the first frame update
    void Start()
    {
       RouteRenderer = GetComponent<Renderer>();
       SelectedColor = new Color(255,246,0);
       DefaultColor = RouteRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointed){
            countdown -= 1f;
        }
        if (countdown < 0f){
            selected = true;
            FlightInfo.SetActive(true);
        }
    }

    public void Pointed(){

        if (!selected){
            pointed = true;
            countdown = pointtime;
            RouteRenderer.material.color = SelectedColor;
            Debug.Log("Pointed");
        }
    }

    public void NotPointed(){

        if (!selected){
            pointed = false;
            RouteRenderer.material.color = DefaultColor;
        }
    }

}
