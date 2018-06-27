using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyllinderRotateScript : MonoBehaviour
{
    public float speed = 1;



    // Use this for initialization
    void Start()
    {
        Debug.Log("DebugTest 1");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 1);
        transform.Rotate(0, 0, speed);

    }
}
