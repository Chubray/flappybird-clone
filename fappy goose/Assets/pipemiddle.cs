using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    public logicscript logic;
    public birdscript life;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        life = GameObject.FindGameObjectWithTag("life").GetComponent<birdscript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 3) && life.alive == true )
        {
            logic.addScore(1);
        }
    }
}
