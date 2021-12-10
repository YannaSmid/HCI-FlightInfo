using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointedRoute : MonoBehaviour
{
    public RouteSelectionHandler SelHandlerObject;

    private RouteSelectionHandler SelChecker;

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
    // Start is called before the first frame update
    void Start()
    {
        SelChecker = SelHandlerObject.GetComponent<RouteSelectionHandler>();
        RouteRenderer = GetComponent<Renderer>();
        SelectedColor = new Color(255,246,0);
        DefaultColor = RouteRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointselect && countdown > 0f && !selected){
            countdown -= 1f;
        }
        //selecteren
        else if (pointselect && countdown <= 0f && !selected){
            selected = true;
            SelChecker.RouteisSelected = true;
            pointselect = false;
            FlightInfo.SetActive(true);
        }
        if (pointundo && countdown > 0f && selected){
            countdown -= 1f;
        }
        //deselecteren
        else if(pointundo && countdown <= 0f && selected){
            selected = false;
            SelChecker.RouteisSelected = false;
            pointundo = false;
            FlightInfo.SetActive(false);
        }
    }

    public void Pointed(){
    //als er niet ergens een route is geselecteerd
        if (!SelChecker.RouteisSelected){
        //kan alleen geselecteerd worden als die nog niet geselecteerd is
            if (!selected){
                pointselect = true;
                countdown = pointtime;
                RouteRenderer.material.color = SelectedColor;
                //Debug.Log("Pointed");
            }
        }
        //als route al geselecteerd is moet dat ongedaan gemaakt kunnen worden
            else if (selected){
                pointundo = true;
                countdown = pointtime;
                RouteRenderer.material.color = DefaultColor;
                Debug.Log("Pointed");
            }
    }

    public void NotPointed(){
        if (!selected){
            pointselect = false;
            RouteRenderer.material.color = DefaultColor;
        }
        else if (selected){
            pointundo = false;
            RouteRenderer.material.color = SelectedColor;
        }
    }

}
