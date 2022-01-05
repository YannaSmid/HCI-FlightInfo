using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointedRoute : MonoBehaviour
{
    public SelectionHandler SelHandlerObject;

    private SelectionHandler SelChecker;
    public Object Route;
    public GameObject FlightInfo;
    public Color SelectedColor;
    public Color DefaultColor;
    public Renderer RouteRenderer;
    bool pointselect = false;

    bool pointundo = false;

    private bool selected = false;

    private float countdown;
    public float pointtime = 5f;

    void Start()
    {
        //Selection Handler keeps track of the selected routes so that there cannot be more than one route selected at the same time
        SelChecker = SelHandlerObject.GetComponent<SelectionHandler>();

        RouteRenderer = GetComponent<Renderer>();
        SelectedColor = new Color(255,246,0);
        DefaultColor = RouteRenderer.material.color;
    }

    void Update()
    {
        if (pointselect && countdown > 0f && !selected){
            countdown -= 1f;
        }
        //select the route
        else if (pointselect && countdown <= 0f && !selected){
            selected = true;
            SelChecker.RouteisSelected = true;
            pointselect = false;
            FlightInfo.SetActive(true);
        }
        if (pointundo && countdown > 0f && selected){
            countdown -= 1f;
        }
        //deselect the route
        else if(pointundo && countdown <= 0f && selected){
            selected = false;
            SelChecker.RouteisSelected = false;
            pointundo = false;
            FlightInfo.SetActive(false);
        }
    }

     //gets called when the user points towards the route
    public void Pointed(){
        //if there isn't a route that is selected
        if (!SelChecker.RouteisSelected && !SelChecker.SelectingRoute)
        {
        //select the route if it is not already selected
            if (!selected)
            {
                SelChecker.SelectingRoute = true;
                pointselect = true;
                countdown = pointtime;
                RouteRenderer.material.color = SelectedColor;
            }
        }
        //deselect the route if the route is selected
        if (selected)
            {
                pointundo = true;
                SelHandlerObject.Deselecting = true;
                countdown = pointtime;
                RouteRenderer.material.color = DefaultColor;
                Debug.Log("Pointed");
            }
    }

    //gets called when the user stops pointing towards the route
    public void NotPointed(){
        if (!selected){
            pointselect = false;
            SelChecker.SelectingRoute = false;
            RouteRenderer.material.color = DefaultColor;
        }
        else if (selected){
            pointundo = false;
            SelHandlerObject.Deselecting = false; 
            SelChecker.SelectingRoute = false;
            RouteRenderer.material.color = SelectedColor;
        }
    }

}
