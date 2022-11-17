using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bombController : MonoBehaviour
{
    public float fallSpeed = 1f;
    public string colorBomb = "";
    int contador;
    public Text puntos;
    public TextMeshProUGUI puntos2;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        puntos2.text = "puntos: " + contador.ToString();
    }
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.name);

        if (colorBomb == "yellow" && other.gameObject.name == "collisionYellow")
        {
            Debug.Log("Bomba amarilla anotada en contenedor amarillo.");
            contador++;
            Destroy(gameObject);
        } else if (colorBomb == "blue" && other.gameObject.name == "collisionBlue")
        {
            Debug.Log("Bomba azul anotada en contenedor azul.");
            contador++;
            Destroy(gameObject);
            
        }
        else if (colorBomb == "red" && other.gameObject.name == "collisionRed")
        {
            Debug.Log("Bomba roja anotada en contenedor roja.");
            contador++;
            Destroy(gameObject);
        }else if(other.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
