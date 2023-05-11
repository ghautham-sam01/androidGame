using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    public Text myText;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            myText.text = "GOOD JOB! YOU WON!";
        }
    }

}
