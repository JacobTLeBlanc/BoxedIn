using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballScript : MonoBehaviour
{

    // Init direction
    private float initDirectionX;
    private float initDirectionY;

    // Current direction
    private float currentX, currentY;

    // Score
    private int score;
    public Text scoreText;

    // Rigidbody
    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();

        initDirectionX = 0.5f;
        initDirectionY = 1.2f;

        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(initDirectionX, initDirectionY);
        currentX = initDirectionX;
        currentY = initDirectionY;

        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D() {
        score++;
        SetScoreText();
    }

    void SetScoreText() {
        scoreText.text = "Score: " + score.ToString();
    }
}
