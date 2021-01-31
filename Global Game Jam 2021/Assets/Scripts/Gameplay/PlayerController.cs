using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D m_rb;
    BoxCollider2D m_boxC;
    MouseHandler mouse;

    public float speed = 3.0f;
    float moveTime = 1.0f;
    float moveTimer = 0.0f;
    
    [SerializeField]
    Vector3 direction_vector;

    bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
      m_rb = GetComponent<Rigidbody2D>();
      m_boxC = GetComponent<BoxCollider2D>();
      direction_vector = transform.position;
      mouse = FindObjectOfType<MouseHandler>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
          m_rb.velocity = Vector2.right.normalized * speed;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
          m_rb.velocity = Vector2.left.normalized * speed;
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
          m_rb.velocity = new Vector2(0, 0);
          m_rb.angularVelocity = 0f;
        }

    }
}
