using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderScript : MonoBehaviour
{

    // Speed of rotation
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            speed = -speed;
        }

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
