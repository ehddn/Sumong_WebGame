using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAvoid : MonoBehaviour
{
    private bool right;
    private bool left;

    private Rigidbody2D rigidbody;

    public int score;
    public Text scoreText;

    private TestGenerator gen;

    void Start()
    {
        right = false;
        left = false;

        score = 0;

        gen = GameObject.Find("TestGenerator").GetComponent<TestGenerator>();

        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.zero;
    }

    
    void Update()
    {
        if(gen.start)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                right = true;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                right = false;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                left = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                left = false;
            }

            if (right)
            {
                rigidbody.MovePosition(new Vector2(transform.position.x + 0.1f, transform.position.y));
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            if (left)
            {
                rigidbody.MovePosition(new Vector2(transform.position.x - 0.1f, transform.position.y));
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        scoreText.text = "점수: " + score;
    }

    public void OnRightClicked()
    {
        right = true;
    }

    public void OnRightReleased()
    {
        right = false;
    }

    public void OnLeftClicked()
    {
        left = true;
    }

    public void OnLeftReleased()
    {
        left = false;
    }
}
