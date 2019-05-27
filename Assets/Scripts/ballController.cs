using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{

    // Init direction
    private float initDirectionX;
    private float initDirectionY;

    // Rigidbody
    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();

        initDirectionX = Random.Range(-1.0f, 1.0f);
        initDirectionY = Random.Range(-1.0f, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(initDirectionX, initDirectionY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
