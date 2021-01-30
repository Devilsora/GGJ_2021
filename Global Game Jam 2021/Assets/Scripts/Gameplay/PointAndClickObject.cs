using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointAndClickObject : MonoBehaviour
{
    BoxCollider2D m_collider;
    MouseHandler mouse;
    Color originalColor;

  public float talkable_range = -1;   //if -1, distance doesn't matter

    // Start is called before the first frame update
    void Start()
    {
      m_collider = GetComponent<BoxCollider2D>();
      mouse = FindObjectOfType<MouseHandler>();
      originalColor = GetComponent<SpriteRenderer>().color;
    }

  // Update is called once per frame

  private void OnMouseDown()
  {
    Debug.Log("On mouse down on object");

    //check if player is in range to trigger dialogue if applicable
    if(talkable_range != -1)
    {
      PlayerController playerRef = FindObjectOfType<PlayerController>();
      Vector3 playerPos = playerRef.gameObject.transform.position;
      float dist = Vector2.Distance(playerPos, transform.position);

      if(dist <= talkable_range)
      {
        Debug.Log("Start dialogue");
      }

    }

    //dialogue stuff here (trigger dialogue box to pop up, click thru dialogue here)
    
    

    Debug.Log("Enter dialogue here");
    
  }

  private void OnMouseEnter()
  {
    GetComponent<SpriteRenderer>().color = Color.red;
    mouse.SetLastObject(gameObject);

  }

  private void OnMouseExit()
  {
    GetComponent<SpriteRenderer>().color = originalColor;
    mouse.SetLastObject(null);
  }

}
