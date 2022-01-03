using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToInstructions : MonoBehaviour
{
    public float pointtime = 20f;
    private float countdown;
    private bool isPointed = false;

    public SpriteRenderer Icon;
    public Color SelectedColor;
    public Color DefaultColor;


    void Start(){
        DefaultColor = Icon.color;
    }
    void Update(){
        
        if (isPointed && countdown >= 0f){
            countdown -= 1f;
        }
        else if (isPointed && countdown <= 0f){
            SceneManager.LoadScene("Instructions");
        }

    }
    
    public void StartInstructions(){

        isPointed = true;
        countdown = pointtime;
        Icon.color = SelectedColor;
        
    }

    public void CutOffInstructions(){

        isPointed = false;
        Icon.color = DefaultColor;

    }
}
