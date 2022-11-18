using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int min, seg;
    public Text texto;

    public Image gameOver;

    int intervalo = 1;
    float nextTime = 0;

    //public bombController objC;

    private void Start() {
        gameOver.enabled=false;
    }
    private void Update() {

        if(Time.time >= nextTime){

            nextTime+= intervalo;
            seg-=1;
        }

        if(seg<0){
            seg = 0;
        }

        if(seg==0 & min >= 1){
            min-=1;
            seg=59;
        }

        if(seg==0 & seg == 0){

            gameOver.enabled=true;
        }

        texto.text = min.ToString("00")+":"+seg.ToString("00");
    
    }
    
}
