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

	
	// Update is called once per frame
	void Update () {

        // if(inProgress)
        // {
    
        //     if (currentValue < 100) {
        //         currentValue += speed * Time.deltaTime;

        //     } 
 
		//     LoadingBar.fillAmount = currentValue / 100;
        // }

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

        //als er niet al een route is geselecteerd
        if(!SelHandlerObject.RouteisSelected || SelHandlerObject.Deselecting){
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