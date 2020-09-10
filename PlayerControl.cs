using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float playerSpeed;
    public bool isHaveKey;
    private float xInput, yInput;
    private GameObject player;

    private Rigidbody2D body;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        isHaveKey = false;

        body = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        getMovement();
    }

    void getMovement()
    {

        //Get Input
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        animator.SetFloat("x", xInput);
        animator.SetFloat("y", yInput);
        

        bool isMoving = (xInput != 0 || yInput != 0);
        animator.SetBool("isMoving", isMoving);

        if (isMoving)
        {
           
            var moveVector = new Vector3(xInput, yInput, 0);

            body.MovePosition(new Vector2((player.transform.position.x + moveVector.x * playerSpeed * Time.deltaTime),
                    player.transform.position.y + moveVector.y * playerSpeed * Time.deltaTime));
        }
    }
}
