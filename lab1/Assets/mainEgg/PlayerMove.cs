using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{

    public Text textbox;
    public string textValue;
    public int checkpoint;


    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "Make it to the fridge, don't get boiled!";
    }


    // Update is called once per frame
    void Update()
    {
        //check current location of egg
        Vector3 currentPosition = transform.position;

        if (transform.position.z > 200 && transform.position.z < 300)
        {
            checkpoint = 1;
        }
        else if (transform.position.z > 300 && transform.position.z < 400)
        {
            checkpoint = 2;
        }
        else if (transform.position.z > 400)
        {
            checkpoint = 3;
        }
        else {
            checkpoint = 4;
        }


        //Allow reset height (back on spoon) if egg falls off spoon
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (checkpoint == 1)
            {
                transform.localPosition = new Vector3(120,-700,200);
                print("Space Hit CH1");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("ORIGIN");
                textbox.text = "CHECKPOINT 1";
            } else if (checkpoint == 2) {
                transform.localPosition = new Vector3(120, -1800, 200);
                print("Space Hit CH2");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("ORIGIN");
                textbox.text = "CHECKPOINT 2";
            } else if (checkpoint == 3)
            {
                transform.localPosition = new Vector3(120, -2900, 200);
                print("Space Hit CH3");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("CHECKPOINT 3");
                textbox.text = "CHECKPOINT 3";
            }
            else
            {
                transform.localPosition = new Vector3(currentPosition.x, 108f, currentPosition.z);
                print("Space Hit");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("ORIGIN");
                textbox.text = "RESET";
            }
        }





        if (Input.GetKey("w")) {

            textbox.text = "";
        }

        if (transform.position.z > 200 && transform.position.z < 300)
        {
            textbox.text = "CHECKPOINT 1 - Keep Going!";
        }
        else if (transform.position.z > 300 && transform.position.z < 400)
        {
            textbox.text = "CHECKPOINT 2 - You can do it!";
        }
        else if (transform.position.z > 400 && transform.position.z < 510)
        {
            textbox.text = "CHECKPOINT 3 - YOUR ALMOST THERE!";
        }
        else if (transform.position.z > 510) {
            textbox.text = "FINISHED!";

        }

        Debug.Log(currentPosition);
        Debug.Log("X = " + currentPosition.x);
        Debug.Log("Y = " + currentPosition.y);
        Debug.Log("Z = " + currentPosition.z);


    }
}
