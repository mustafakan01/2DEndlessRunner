using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Border")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
