using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * .25f);
        if (transform.position.y < 0) {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 4f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 4f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2f);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "floor")
        {
            if (rb.velocity.y > 0)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (1.5f) * Time.deltaTime;
            }
                        rb.AddForce(Vector3.up* 7f, ForceMode.Impulse);
        }
    }
}
