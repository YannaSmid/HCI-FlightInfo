using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromInsToMain : MonoBehaviour
{
    public float pointtime = 30f;
    private float countdown;
    private bool isPointed = false;

    //Selection handler keeps track of what gets selected
    public GameObject SelHandlerObject;
    private SelectionHandler SelHandler;

    public SpriteRenderer Icon;
    public Color SelectedColor;
    public Color DefaultColor;


    void Start(){
        //saves the selectionhandler information into the selhandler variable
        SelHandler = SelHandlerObject.GetComponent<SelectionHandler>();

        //saves the route color when it is not selected
        DefaultColor = Icon.color;
    }
    void Update(){
        
        if (isPointed && countdown >= 0f){
            countdown -= 1f;
        }
        else if (isPointed && countdown <= 0f){
            SceneManager.LoadScene("MainGlobe");
        }

    }
    
    public void StartMenu(){
        //button gets selected
        SelHandler.ButtonSelection = true;

        isPointed = true;
        countdown = pointtime;
        Icon.color = SelectedColor;
        
    }

    public void CutOffMenu(){
        //selection has stopped
        SelHandler.ButtonSelection = false;

        isPointed = false;
        Icon.color = DefaultColor;

    }
}
