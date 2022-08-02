using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PARALLEX : MonoBehaviour
{
   
    private float length,startpros;
    public GameObject cam;
    public float parallaxeffect;
    void Start()
    {
        startpros =transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
     private void FixedUpdate() 
     {
         float temp = (cam.transform.position.x * (1 - parallaxeffect ));
        float dist = (cam.transform.position.x * parallaxeffect);

        transform.position = new Vector3 (startpros + dist, transform.position.y,transform.position.z);

         if(temp > startpros + length) startpros += length;
           else if(temp < startpros - length ) startpros -= length;
     }
}