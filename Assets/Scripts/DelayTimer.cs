using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DelayTimer : MonoBehaviour
{
     public GameObject countdownTimer;
     public float timer2 = 0;
     public GameObject mainPlayer;
    public GameObject scriptManager;
    // Start is called before the first frame update
    void Start()
    {
       // Time.timeScale = 0;
       // StartCoroutine(ExampleCoroutine());

    }
   
    public void endGame()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
    }
}
