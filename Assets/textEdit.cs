using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textEdit : MonoBehaviour
{
    public Text myText;
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0.0f)
        {
            timeLeft -= Time.deltaTime;
            myText.text = "Time Left: " + timeLeft;
        }
        else {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
