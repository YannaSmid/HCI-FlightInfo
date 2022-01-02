using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToInstructions : MonoBehaviour
{
    public float pointtime = 20f;
    private float countdown;
    private bool isPointed = false;

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
        
    }

    public void CutOffInstructions(){

        isPointed = false;

    }
}
