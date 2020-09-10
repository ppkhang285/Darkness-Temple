using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nextPosition = player.GetComponent<Transform>().position;
        nextPosition.z = transform.position.z;
        float moveSpeed = player.GetComponent<PlayerControl>().playerSpeed;
        transform.position = Vector3.Lerp(transform.position, nextPosition, Time.deltaTime * moveSpeed);
    }
}
