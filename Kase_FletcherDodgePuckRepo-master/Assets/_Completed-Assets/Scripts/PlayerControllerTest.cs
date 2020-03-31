using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("GoRight")
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //    //spriteRenderer.flipX = false;
        //}
        //else if (Input.GetButton("GoLeft"))
        //{
        //    transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        //    //spriteRenderer.flipX = true;
        //}
    }

    void FixedUpdate()
    {
        ////Store the current horizontal input in the float moveHorizontal.
        //float moveHorizontal = Input.GetAxis("Horizontal");

        ////Store the current vertical input in the float moveVertical.
        //float moveVertical = Input.GetAxis("Vertical");

        ////Use the two store floats to create a new Vector2 variable movement.
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        
    }
}
