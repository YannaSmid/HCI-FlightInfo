using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public float pointtime = 30f;
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
            SceneManager.LoadScene("Menu");
        }

    }
    
    public void StartMenu(){

        isPointed = true;
        countdown = pointtime;
        Icon.color = SelectedColor;
        
    }

    public void CutOffMenu(){

        isPointed = false;
        Icon.color = DefaultColor;

    }
}
