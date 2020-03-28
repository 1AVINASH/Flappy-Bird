using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject enemy;
    public float vertVelocity;
    private GameObject enemyPipe;
    public GameObject enemySpawner;
    float maxTime = 0.8f;
    float timer;
    public Text timerText;
    public GameObject pauseCanvas;
    public Text pauseMenuScore;
    public float timeSinceStart ;
    public GameObject mainCamera;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(false);
        mainCamera.GetComponent<DelayTimer>().countdownTimer.SetActive(true);
        mainPlayer.transform.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(ExampleCoroutine());
        Debug.Log(timeSinceStart);
    }
    
   
    IEnumerator ExampleCoroutine()
    {
        Debug.Log("new game");
        while (timeSinceStart < 1.25f)
            yield return 0;
        Time.timeScale = 1;
        mainCamera.GetComponent<DelayTimer>().countdownTimer.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceStart += Time.unscaledDeltaTime;

        if (timer > maxTime)
            {
                float height = Random.Range(-1.5f, 1.5f);
                enemyPipe = Instantiate(enemy);
                timer = 0;
                enemyPipe.transform.position = new Vector3(enemySpawner.transform.position.x, 0.66f + height, -1.2f);
            }
            timer += Time.deltaTime;
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
                mainPlayer.GetComponent<Rigidbody2D>().velocity = Vector2.up * vertVelocity;
        if (Input.GetKeyDown(KeyCode.Escape))
            pauseGame();
    }
    public void pauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
        Vector3 enemyPosition = enemyPipe.transform.position;
        enemyPipe.transform.position = enemyPosition;
        enemyPipe.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
        pauseMenuScore.text = mainPlayer.GetComponent<destroyObj>().score.ToString();
            //scoreAdd.score.ToString();
    }
    public void resumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

}
