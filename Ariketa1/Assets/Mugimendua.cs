using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mugimendua : MonoBehaviour
{
    public float velocidad = 5f;
    public string dir = "DERECHA";
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x > 10f)
        {
            transform.position += Vector3.right;
        } else if (transform.position.z > 10f)
        {
            transform.position += Vector3.forward;
        } else if (transform.position.x <= 10f)
        {
            transform.position += Vector3.left;
        }
    }
}
