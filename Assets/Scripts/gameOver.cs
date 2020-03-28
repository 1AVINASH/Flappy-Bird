using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class gameOver : MonoBehaviour
{
    // public GameObject gameEndCanvas;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
   
   
    public void quitApplication()
    {
        Application.Quit();
    }
    public void newGame()
    {
        SceneManager.LoadScene("MainGame");
       // Time.timeScale = 0;
       // StartCoroutine(ExampleCoroutine());
    }
   
}
