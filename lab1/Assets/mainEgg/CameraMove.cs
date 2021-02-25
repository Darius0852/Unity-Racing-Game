using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float YAxis;
    public float XAxis;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void movingForward()
    {
        Vector3 position = this.transform.position;
        float go = 0.5f;
        position.z += go;
        this.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            movingForward();
        }

        if (Input.GetKey("d"))
        {
            Vector3 position = this.transform.position;
            float goRight = 0.5f;
            position.x += goRight;
            this.transform.position = position;
        }

        if (Input.GetKey("a"))
        {
            Vector3 position = this.transform.position;
            float goLeft = 0.5f;
            position.x -= goLeft;
            this.transform.position = position;
        }




        if (Input.GetKey("s"))
        {
            Vector3 position = this.transform.position;
            float goBack = 0.5f;
            position.z -= goBack;
            this.transform.position = position;
        }

        //CHECKPOINTS
        //we need to check the position of the egg, and which checkpoint has been reached and respawn the spoon accordingly
        //We can acces non-static variables from other script using Gameobject and using a tag
        GameObject thePlayer = GameObject.Find("Player");
        PlayerMove eggPlayer = thePlayer.GetComponent<PlayerMove>();
        int currentCheckpoint = eggPlayer.checkpoint;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (currentCheckpoint == 1)
            {
                transform.localPosition = new Vector3(120, -600, 200);
            }
            else if (currentCheckpoint == 2)
            {
                transform.localPosition = new Vector3(120, -3000, 200);
            }
            else if (currentCheckpoint == 3)
            {
                transform.localPosition = new Vector3(120, -4400, 200);
            }
            else
            {
                transform.localPosition = new Vector3(62.1f, 154.8f, 70.3f);
            }
        }





        ////check current location of egg
        //Vector3 currentPosition = transform.position;

        ////Allow reset height (back on spoon) if egg falls off spoon
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    transform.localPosition = new Vector3(62.1f, 154.8f, 70.3f);
        //    print("Space Hit");
        //    //reset forces acting on egg
        //    GetComponent<Rigidbody>().velocity = Vector3.zero;
        //    Debug.Log("ORIGIN");

        //}


    }
}
