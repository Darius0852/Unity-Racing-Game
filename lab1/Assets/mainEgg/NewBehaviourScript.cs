using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void moveForward()
    {
        Vector3 position = this.transform.position;
        float go = 0.1f;
        position.z += go;
        this.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey("w"))
        {
            moveForward();
        }

        if (Input.GetKey("d"))
        {
            Vector3 position = this.transform.position;
            float goRight = 0.1f;
            position.x += goRight;
            this.transform.position = position;
        }

        if (Input.GetKey("a"))
        {
            Vector3 position = this.transform.position;
            float goLeft = 0.1f;
            position.x -= goLeft;
            this.transform.position = position;
        }




        if (Input.GetKey("s"))
        {
            Vector3 position = this.transform.position;
            float goBack = 0.1f;
            position.z -= goBack;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, 10 * Time.deltaTime);

        }


    }
}
