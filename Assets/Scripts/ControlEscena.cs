using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscena : MonoBehaviour
{
    public List<GameObject> bombs;
    public Transform spawn;
    GameObject bombaGenerada;
    int tiempoSpawn;
    Vector3 positionSpawn;
    int indice;

    // Start is called before the first frame update
    void Start()
    {
        positionSpawn = spawn.position;
        tiempoSpawn = 0;
        InvokeRepeating("generarBombas", 0f, 5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        positionSpawn = spawn.position;
        //generarBombas();
    }

    public void generarBombas()
    {
        indice = Random.Range(0,bombs.Count);
        Debug.Log(tiempoSpawn);
        bombaGenerada = Instantiate(bombs[indice],positionSpawn,Quaternion.identity);
        
    }

}
