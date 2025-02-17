using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += Vector3.up;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += Vector3.down;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}
