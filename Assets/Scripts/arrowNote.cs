using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowNote : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.1f,0,Space.World);

        if(transform.position.y < -10.0f){
            Destroy(gameObject);
        }
    }
}
