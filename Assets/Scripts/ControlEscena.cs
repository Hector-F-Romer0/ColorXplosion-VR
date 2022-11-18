using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscena : MonoBehaviour
{
    public List<GameObject> bombs;
    public List<Transform> spawn;
    public int timeSpawn = 0;
    GameObject generatedBomb;
    Vector3 positionSpawn;
    public int index;
    int index2;

    // Start is called before the first frame update
    void Start()
    {
        positionSpawn = spawn[0].position;
        InvokeRepeating("spawnBombs", 0f, 2f);
     
        
    }

    // Update is called once per frame
    void Update()
    {
        index2 = Random.Range(0,spawn.Count);
        positionSpawn = spawn[index2].position;
    }

    public void spawnBombs()
    {
        index = Random.Range(0,bombs.Count);
        generatedBomb = Instantiate(bombs[index],positionSpawn,Quaternion.identity);
        
    }
}
