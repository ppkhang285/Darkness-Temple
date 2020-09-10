using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{

    public GameObject player;

    private GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "char")
        {
            key.SetActive(false);

            player.GetComponent<PlayerControl>().isHaveKey = true;

        }
    }
}
