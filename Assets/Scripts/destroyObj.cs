using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class destroyObj : MonoBehaviour
{
    public float score = 0;
    public ParticleSystem blast;
    private float highScore = 0;
    public GameObject mainCamera;
    public GameObject scoreText;
    public float timer3 = 0;
    //public GameObject enemyPipe;
    // Start is called before the first frame update
    void Start()
    {
        blast.gameObject.SetActive(false);
       // blast.GetComponent<ParticleSystem>().Stop();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timer3 = 0;
        StartCoroutine(destroyBall());
        blast.gameObject.SetActive(true);
        blast.transform.position = gameObject.transform.position;
        if (!blast.isPlaying)
        {
            blast.Play();
            blast.enableEmission = true;
            // mainCamera.GetComponent<DelayTimer>().endGameScript();
        }
        // mainCamera.GetComponent<DelayTimer>().endGameScript();
        Destroy(GetComponent<Rigidbody2D>());
        GetComponent<SpriteRenderer>().enabled = false;
    }
    IEnumerator destroyBall()
    {
        
        while (timer3<1.5f)
            yield return 0;
        SceneManager.LoadScene("NewGame");
        
        
        //yield return 0;
    }
  

    // Update is called once per frame
    void Update()
    {
        timer3 += Time.unscaledDeltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(score);
        score += 10;
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}
