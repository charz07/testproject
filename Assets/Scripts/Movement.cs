using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpStrength = 3.5f;
    public Rigidbody2D myRigidBody;
    public ScoreLogic logic;
    public bool catAlive = true;
    private float inputBuffer;
    private float scoreBuffer;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(catAlive)
        { 
            if (inputBuffer == 0)
                inputBuffer = Time.time;
            if (scoreBuffer == 0)
                scoreBuffer = Time.time;
            if(Time.time - inputBuffer > 0.5f && (Input.GetKeyDown(KeyCode.Space) == true || Input.GetKeyDown(KeyCode.UpArrow) == true))
            {
                myRigidBody.velocity = Vector2.up * jumpStrength;
                inputBuffer = 0.0f;
            }
            if(Time.time -scoreBuffer > 0.02f)
            {
                logic.addScore();
                scoreBuffer = 0.0f;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.gameOver();
        catAlive = false;
    }

}
