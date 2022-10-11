using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float moveSpped;
    public Rigidbody2D rb;
    public GameObject gameOverText, restartButton, backButton;


    private Vector2 moveDirection;

    private ScoreManager theScore;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        backButton.SetActive(false);

        theScore = FindObjectOfType<ScoreManager> () ;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }


    /// fixed frame rate

    void FixedUpdate()
    {
        Move();

    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpped, moveDirection.y * moveSpped);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            
            gameObject.SetActive(false);
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            backButton.SetActive(true);

            theScore.scoreIncreasing = false;

        }
    }
}
