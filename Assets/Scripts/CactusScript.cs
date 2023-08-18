using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -2.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed);
         //Debug.Log(transform.position.x);
        if(transform.position.x < deadzone)
        {
            //Debug.Log("cactus begone");
        }
    }
}
