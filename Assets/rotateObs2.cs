using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObs2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.PingPong(Time.time*100,88)-88; 
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 2f, ForceMode.Impulse);
        }
    }

}
