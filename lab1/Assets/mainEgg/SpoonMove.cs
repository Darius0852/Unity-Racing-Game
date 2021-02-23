using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpoonMove : MonoBehaviour
{

    public float turningSpeed = 100; //Rotation speed of spoon
    public float movementSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Functions for movement
    public void moveForward()
    {
        Vector3 position = this.transform.position;
        float go = 0.5f;
        position.z += go;
        this.transform.position = position;
    }

    public void moveBackward() {
        Vector3 position = this.transform.position;
        float goBack = 0.5f;
        position.z -= goBack;
        this.transform.position = position;
    }

    public void moveRight() {
        Vector3 position = this.transform.position;
        float goRight = 0.5f;
        position.x += goRight;
        this.transform.position = position;
    }

    public void moveLeft() {
        Vector3 position = this.transform.position;
        float goLeft = 0.5f;
        position.x -= goLeft;
        this.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        //Handle Spoon Movements

        //Rotate left or right
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
            transform.Rotate(0, horizontal, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            float verticle = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
            transform.Rotate(verticle, 0, 0);
        }

        //Move forward, back left and right
        if (Input.GetKey("w"))
        {
            moveForward();
        }

        if (Input.GetKey("s"))
        {
            moveBackward();
        }

        if (Input.GetKey("a"))
        {
            moveLeft();
        }

        if (Input.GetKey("d"))
        {
            moveRight();
        }



        //check current location of egg
        Vector3 currentPosition = transform.position;

        //Allow reset height (back on spoon) if egg falls off spoon
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localPosition = new Vector3(62.1f, 108.85f, 110.35f);
            print("Space Hit");
            //reset forces acting on egg
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("ORIGIN");

        }


    }
}
