using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public int score = 7;
    public float speed = 10.0f;
    public float yRange = 10.0f;
    public float xRange = 10.0f;
    public Vector2 range = new Vector2(10.0f, 10.0f);

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 myV2 = transform.position;
        //if (transform.position.x > xRange)
        //{
        //    transform.position = new Vector3(xRange, transform.position.y, transform.position.x);
        //    //Debug.Log(myV2);
        //}
        //if (transform.position.x < -xRange)
        //{
        //    transform.position = new Vector3(-xRange, transform.position.y, transform.position.x);
        //}
        //if (transform.position.y > yRange)
        //{
        //    transform.position = new Vector3(yRange, transform.position.y, transform.position.x);
        //}
        //if (transform.position.y < -yRange)
        //{
        //    transform.position = new Vector3(-yRange, transform.position.y, transform.position.x);
        //}



        //Debug.Log("myV2: " + myV2 + xRange);

        //var pos = transform.position;
        //pos.y = cameraY;
        //transform.position = pos;

        float moveHorizontal = Input.GetAxis("Horizontal");
        //Debug.Log(moveHorizontal);

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal,moveVertical);
        //Debug.Log(movement);

        transform.Translate(movement * speed * Time.deltaTime);
        
   
    }
}
