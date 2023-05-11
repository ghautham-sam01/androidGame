using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speedFactor;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("Launch", speedFactor, 3.0f);
    }

    void Launch()
    {
        rb.AddForce(Vector3.up * 7f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
