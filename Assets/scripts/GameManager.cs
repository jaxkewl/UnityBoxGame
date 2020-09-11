using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public float restartDelay = 1f;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log($"Game over");
            gameHasEnded = true;

            //restart game
            Invoke("Restart", restartDelay);

        }
    }

    public void CompleteLevel()
    {
        Debug.Log($"Level Complete");
        completeLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
