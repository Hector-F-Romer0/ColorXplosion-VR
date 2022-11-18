using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscena : MonoBehaviour
{
    public List<GameObject> bombs;
    public Transform spawn;
    public int timeSpawn = 0;
    GameObject generatedBomb;
    Vector3 positionSpawn;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        positionSpawn = spawn.position;
        InvokeRepeating("spawnBombs", 0f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void spawnBombs()
    {
        index = Random.Range(0,bombs.Count);
        generatedBomb = Instantiate(bombs[index],positionSpawn,Quaternion.identity);
        
    }

}
