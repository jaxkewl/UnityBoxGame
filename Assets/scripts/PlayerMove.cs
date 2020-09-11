using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Transform transform;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500;
    public float jumpForce = 50;

    public bool gameHasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.useGravity = true;
        // rigidbody.AddForce(0, 10, 0, ForceMode.Impulse);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            gameHasStarted = true;
        }
        if (!gameHasStarted) return;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        }
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
