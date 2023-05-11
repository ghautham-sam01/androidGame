using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class rotateObs1 : MonoBehaviour
{
    public GameObject tower;
    public float speedFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.RotateAround(tower.transform.position,  Vector3.up, 100f * Time.deltaTime*speedFactor);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 5f, ForceMode.Impulse);
        }
    }

}
