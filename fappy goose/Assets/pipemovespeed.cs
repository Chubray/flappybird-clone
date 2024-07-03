using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovespeed : MonoBehaviour
{
    public float ms = 5; // movement speed variable
    public float deadzone = -30; //deadzone XD
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * ms) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("pipe deleted");
        }
    }
}
