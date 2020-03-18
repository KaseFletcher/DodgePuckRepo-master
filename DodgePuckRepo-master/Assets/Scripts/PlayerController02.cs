using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    public float speed;
    public float xRange;
    public float yRange;
    public GameObject Puck;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
        //Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
        //Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
    }

    //Keeps Player in the Room
    private void LateUpdate()
    {
        //Keep Player within xRange (Left and Right sides)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Puck,new Vector2(Random.Range(-xRange,xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //count how many enemies there are in the scene
        GameObject[] puckArray;
        puckArray = GameObject.FindGameObjectsWithTag("Puck");
        Debug.Log("Puck Count: " + puckArray.Length);
       

        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
