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

    SpriteRenderer renderer;
  
    public Sprite standing;
    public Sprite moving;

    // Start is called before the first frame update
    void Start()
    {
      m_rb = GetComponent<Rigidbody2D>();
      m_boxC = GetComponent<BoxCollider2D>();
      direction_vector = transform.position;
      mouse = FindObjectOfType<MouseHandler>();
      renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fixedPos = new Vector3(Mathf.Clamp(transform.position.x, -12.5f, 11f), transform.position.y, transform.position.z);

        transform.position = fixedPos;

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
          m_rb.velocity = Vector2.right.normalized * speed;
          renderer.sprite = moving;
          renderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
          m_rb.velocity = Vector2.left.normalized * speed;
          renderer.sprite = moving;
          renderer.flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
          m_rb.velocity = new Vector2(0, 0);
          renderer.sprite = standing;
          m_rb.angularVelocity = 0f;
        }

    }
}
