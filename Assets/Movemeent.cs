using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movemeent : MonoBehaviour
{Rigidbody rb;
    float speed = 5f;
 
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
 
    // Update is called once per frame
    void Update()
    {
        
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
 
        Vector3 getVel = new Vector3(xMove, 0, zMove) * speed;
        rb.velocity = getVel;

    }

    void OnCollisionEnter(Collision collision){
        
    }
}
