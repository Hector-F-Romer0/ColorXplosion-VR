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
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (colorBomb == "yellow" && other.gameObject.tag == "yellowContainer")
        {
            Debug.Log("Bomba amarilla anotada en contenedor amarillo.");
            Destroy(gameObject);
        }
        //if(other.gameObject.tag == "Floor")
        //{
        //    Destroy(gameObject);

        //}
        

    }
}
