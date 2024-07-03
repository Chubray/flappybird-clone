using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float height = 6;
    public float tilt = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
        
    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - height;
        float highestpoint = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), Quaternion.Euler(0, 0, Random.Range(-15, 15 )));
    }
}
