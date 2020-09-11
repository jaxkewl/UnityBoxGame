using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMove playerMove;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag.Equals("Obstacle"))
        {
            Debug.Log($"we hit something {other.ToString()}");
            playerMove.enabled = false;
            GetComponent<PlayerMove>().enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
