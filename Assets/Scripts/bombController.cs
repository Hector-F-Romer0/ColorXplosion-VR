using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bombController : MonoBehaviour
{
    //public float fallSpeed = 1f;
    public string colorBomb = "";
    PointsLogic contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = FindObjectOfType<PointsLogic>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (colorBomb == "yellow" && other.gameObject.name == "YellowContainer")
        {
            Debug.Log("Bomba amarilla anotada en contenedor amarillo.");
            contador.contador++;
            Destroy(gameObject);
        }
        else if (colorBomb == "blue" && other.gameObject.name == "BlueContainer")
        {
            Debug.Log("Bomba azul anotada en contenedor azul.");
            contador.contador++;
            Destroy(gameObject);

        }
        else if (colorBomb == "red" && other.gameObject.name == "RedContainer")
        {
            Debug.Log("Bomba roja anotada en contenedor roja.");
            contador.contador++;
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Floor")
        {
            contador.contador--;
            if (contador.contador < 0)
            {
                contador.contador = 0;
            }
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
