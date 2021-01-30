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
      if(moving)
      {
        moveTimer += Time.deltaTime;

        if(moveTimer >= moveTime)
        {
          moving = false;
          m_rb.velocity = new Vector2(0, 0);
          m_rb.angularVelocity = 0f;
        }
        
      }



      //check if player is clicking on an object

      //if not clicking an object, move in direction of where mouse is
      if (Input.GetMouseButtonDown(0) && mouse.GetLastObject() == null)
      {
        //if(clicked on object)
        //{
        //  //dont do any movement
        //}

        if(!moving)
        {
          Vector3 workingPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

          direction_vector.x = workingPoint.x;
          direction_vector.y = 0;
          direction_vector.z = transform.position.z;

          moving = true;
          moveTimer = 0.0f;

          m_rb.velocity = direction_vector.normalized * speed;
        }
        
      }

      
      
  }
}
