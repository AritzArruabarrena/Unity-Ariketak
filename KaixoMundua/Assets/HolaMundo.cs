using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolaMundo : MonoBehaviour
{
    public GameObject cube1, cube2, cube3;
    public Text textoPantalla;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        textoPantalla.text = "Hola mundo!";
    }
    void Update()
    {
        cube1.transform.Rotate(0, speed * Time.deltaTime, 0);
        cube2.transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        cube3.transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
