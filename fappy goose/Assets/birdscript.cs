using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flappower;
    public logicscript logic;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        {
            myRigidbody.velocity = Vector2.up * flappower;
        }

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            alive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        alive = false;
        logic.gameOver();
    }
    
}
