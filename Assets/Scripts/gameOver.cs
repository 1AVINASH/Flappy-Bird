using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    public GameObject gameEndCanvas;
    public float highScore = 0;
    public GameObject mainPlayer;
    public GameObject enemyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        newGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endGame();
        Debug.Log("no");
    }
   
    public bool endGame()
    {
        Time.timeScale = 0;
        gameEndCanvas.SetActive(true);
        scoreAdd.score = 0;
        if (scoreAdd.score > highScore)
        {
            highScore = scoreAdd.score;
        }
       // mainPlayer.transform.position = new Vector3(0f, -1.6f, 0f);
        Destroy(enemyPlayer);
        return true;
        //enemyPlayer.transform.position = new Vector3(11f, 0.4f, -1.2f);
    }
    public void quitApplication()
    {
        Application.Quit();
    }
    public void newGame()
    {

        gameEndCanvas.SetActive(false);
        Time.timeScale = 1;
        //mainPlayer.transform.position = new Vector3(0f, -1.6f, 0f);
    }
}
