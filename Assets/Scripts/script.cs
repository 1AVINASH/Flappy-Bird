using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject enemy;
    public float vertVelocity;
    private static GameObject enemyPipe;
    public GameObject enemySpawner;
    int maxTime = 1;
    float timer = Time.deltaTime;
    
    
    //public Text KO;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        //float Time.time;

        if (timer > maxTime)
        {
            float height = Random.Range(-1.5f, 1.5f);
            enemyPipe = Instantiate(enemy);            
            timer = 0;
            enemyPipe.transform.position = new Vector3(enemySpawner.transform.position.x, 0.66f + height, -1.2f);
        }
        timer += Time.deltaTime;
        //enemyPipe.transform.position += Vector3.left * enemySpeed * Time.deltaTime;
       // enemyPipe.GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed,0);
   

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            mainPlayer.GetComponent<Rigidbody2D>().velocity = Vector2.up * vertVelocity;
    }

    
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("gameover"); 
       // gameOver.endGame();
    }
    //enemyPipe.transform.Translate(-0.1f, 0, 0);


}
