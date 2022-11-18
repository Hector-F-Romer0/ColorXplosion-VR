using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsLogic : MonoBehaviour
{
   public int contador;
   public Text texto;
   
    

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;

    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Puntos: "+contador.ToString();
        
    }
}
