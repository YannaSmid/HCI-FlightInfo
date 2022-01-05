using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToInstructions : MonoBehaviour
{
    public float pointtime = 30f;
    private float countdown;
    private bool isPointed = false;

    //Selection handler keeps track of what gets selected
    public GameObject SelHandlerObject;
    private SelectionHandler SelHandler;

    public SpriteRenderer Icon;

    //the route color
    public Color SelectedColor;
    public Color DefaultColor;


    void Start(){
        //saves the selectionhandler information into the selhandler variable
        SelHandler = SelHandlerObject.GetComponent<SelectionHandler>();

        //saves the route color when it is not selected
        DefaultColor = Icon.color;
    }
    void Update(){
        //if the user is pointing they need to hold it for 3 seconds
        if (isPointed && countdown >= 0f){
            countdown -= 1f;
        }//when the 3seconds are over they go to the Instructions
        else if (isPointed && countdown <= 0f){
            SceneManager.LoadScene("Instructions");
        }

    }
    
    //this function is being called when the user is pointing towards the help Icon
    public void StartInstructions(){
        //button gets selected
        SelHandler.ButtonSelection = true;

        //selection is in progress
        isPointed = true;
        countdown = pointtime;
        Icon.color = SelectedColor;
        
    }

    public void CutOffInstructions(){
        //selection has stopped
        SelHandler.ButtonSelection = false;
        isPointed = false;
        Icon.color = DefaultColor;

    }
}
