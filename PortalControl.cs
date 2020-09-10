using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalControl : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.GetComponent<PlayerControl>().isHaveKey == true)
        {
            SceneManager.LoadScene(1);
        }
    }
}
