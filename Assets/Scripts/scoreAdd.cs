using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreAdd : MonoBehaviour
{
    
    public static float score = 0;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(score);
        score += 10;
        //return score;
    }
   
}
