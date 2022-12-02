using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){ //-- OnTriggerExit, OnTriggerStay
         GameObject triggering = col.transform.gameObject;

        Debug.Log("Triggered by "+triggering.name+"!");

        GameObject.Find("Spot Light").GetComponent<Light>().enabled = true;
    }
}
