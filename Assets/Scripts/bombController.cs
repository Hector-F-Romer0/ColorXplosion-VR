using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    public float fallSpeed = 1f;
    public string colorBomb = "";

    // Start is called before the first frame update
    void Start()
    {
;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.name);

        if (colorBomb == "yellow" && other.gameObject.name == "collisionYellow")
        {
            Debug.Log("Bomba amarilla anotada en contenedor amarillo.");
            Destroy(gameObject);
        } else if (colorBomb == "blue" && other.gameObject.name == "collisionBlue")
        {
            Debug.Log("Bomba azul anotada en contenedor azul.");
            Destroy(gameObject);
        }
        else if (colorBomb == "red" && other.gameObject.name == "collisionRed")
        {
            Debug.Log("Bomba roja anotada en contenedor roja.");
            Destroy(gameObject);
        }else if(other.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
