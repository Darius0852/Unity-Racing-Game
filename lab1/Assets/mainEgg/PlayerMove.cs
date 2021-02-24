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

        if (transform.position.z > 200 && transform.position.z < 400)
        {
            checkpoint = 1;
        }
        else if (transform.position.z > 400 && transform.position.z < 600)
        {
            checkpoint = 2;
        }
        else if (transform.position.z > 600)
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
                transform.localPosition = new Vector3(120,-600,200);
                print("Space Hit CH1");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("ORIGIN");
                textbox.text = "CHECKPOINT 1";
            } else if (checkpoint == 2) {
                transform.localPosition = new Vector3(120, -3000, 200);
                print("Space Hit CH2");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("ORIGIN");
                textbox.text = "CHECKPOINT 2";
            } else if (checkpoint == 3)
            {
                transform.localPosition = new Vector3(120, -4400, 200);
                print("Space Hit CH3");
                //reset forces acting on egg
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("CHECKPOINT 3");
                textbox.text = "RESET";
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

        if (transform.position.z > 200 && transform.position.z < 300) {
            textbox.text = "Keep Going";
        }

        Debug.Log(currentPosition);
        Debug.Log("X = " + currentPosition.x);
        Debug.Log("Y = " + currentPosition.y);
        Debug.Log("Z = " + currentPosition.z);


    }
}
