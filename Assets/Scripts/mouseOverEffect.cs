using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void sizeIncrease()
    {
        do
        {
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        } while (transform.localScale.x < 1.5f);
    }
    public void sizeDecrease()
    {
        do
        {
            transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
        } while (transform.localScale.x > 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
