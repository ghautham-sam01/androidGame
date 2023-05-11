using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBack : MonoBehaviour
{
    // Start is called before the first frame update
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
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 5f, ForceMode.Impulse);
        }
    }

}
