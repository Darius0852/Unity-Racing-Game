using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{

    public Text textbox;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        //check current location of egg
        Vector3 currentPosition = transform.position;


        //Allow reset height (back on spoon) if egg falls off spoon
        if (Input.GetKey(KeyCode.Space))
        {

            transform.localPosition = new Vector3(currentPosition.x, 108f, currentPosition.z);
            print("Space Hit");
            //reset forces acting on egg
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("ORIGIN");

        }

        if (currentPosition.z > 100.0f) {

            textbox.text = "HELLO";
        }

        Debug.Log(currentPosition);
        Debug.Log("X = " + currentPosition.x);
        Debug.Log("Y = " + currentPosition.y);
        Debug.Log("Z = " + currentPosition.z);


    }
}
