using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointedRoute : MonoBehaviour
{
    public Object Route;
    public Color SelectedColor;
    public Color DefaultColor;
    public Renderer RouteRenderer;
    public bool pointed = false;
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
            
            
        }
    }

    public void Pointed(){
        pointed = true;
        RouteRenderer.material.color = SelectedColor;
        Debug.Log("Pointed");
    }

    public void NotPointed(){
        pointed = false;
        RouteRenderer.material.color = DefaultColor;
    }

}
