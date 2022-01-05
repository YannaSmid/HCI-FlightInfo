using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public SelectionHandler SelHandlerObject;
    public GameObject ProgressImage;
    public Image LoadingBar;
	float currentValue;
	public float speed;
    public bool inProgress = false;

    public float pointtime = 30f;
    private float timer;

	

	void Update () {

        if(inProgress)
        {
    
            if (currentValue < 100 && timer <= pointtime) {
                timer += 1f;
                currentValue = timer / pointtime;

            } 
            
		    LoadingBar.fillAmount = currentValue;
        }
	}

    public void StartProgressBar(){

        //only if there has already been a route selected or a route needs to get deselected
        if(!SelHandlerObject.RouteisSelected || SelHandlerObject.Deselecting || SelHandlerObject.ButtonSelection){
            currentValue = 0;
            timer = 0;
            ProgressImage.SetActive(true);
            inProgress = true;
        }
    }

    public void StopProgressBar(){
        inProgress = false;
        ProgressImage.SetActive(false);
        
    }
}