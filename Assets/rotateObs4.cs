using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObs4 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedFactor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.PingPong(Time.time * speedFactor, 100)-45;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward * 2.0f);
    }
}
