﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointAndClickObject : MonoBehaviour
{
    BoxCollider2D m_collider;
    MouseHandler mouse;
    Color originalColor;

    public bool highlightsOnMouse = true;
    public float talkable_range = -1;   //if -1, distance doesn't matter

    public bool canAddToInventory = false;
    public InventoryItem invItem;

    public List<string> interactableTags;

    //dialogue objects where applicable
    //regular dialogue
    //item used on

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

    //check if mouse state is trying to use an object (using item in hand)
    if (mouse.GetCurrentState() != MouseState.WaitingForSecondObject)
    {
      mouse.ChangeState(MouseState.ClickedObject);
      Debug.Log("On mouse down on object");

      PlayerController playerRef = FindObjectOfType<PlayerController>();
      Vector3 playerPos = playerRef.gameObject.transform.position;
      float dist = Vector2.Distance(playerPos, transform.position);

      //check if player is in range to trigger dialogue if applicable
      if (talkable_range == -1)
      {
        Debug.Log("Start dialogue");

        //add to inventory
        if (canAddToInventory)
        {
          Inventory.Instance.AddToList(invItem);
        }
      }
      else
      {
        if (dist <= talkable_range)
        {

        }
      }

      //dialogue stuff here (trigger dialogue box to pop up, click thru dialogue here)
      Debug.Log("Enter dialogue here");
    }
    else
    {
      Debug.Log("Waiting for second object");
      //currently waiting for second object

      List<string> mouseTags = mouse.GetItemTags();

      //compare tags in mouse with tags on object - see if they're compatible
      foreach(string s in interactableTags)
      {
        for(int i = 0; i < mouseTags.Count; i++)
        {
          if(s == mouseTags[i])
          {
            Debug.Log("Compatable tag exists");
            //do whatever method assocaited with tag

            mouse.ChangeState(MouseState.Idle);
          }
        }
      }

      //if not display "dont work" message
      Debug.Log("Compatable tag doesnt exist");
      mouse.ChangeState(MouseState.SecondObjectInvalid);
    }
    
    

    
    
  }

  private void OnMouseEnter()
  {
    if(mouse.GetCurrentState() != MouseState.WaitingForSecondObject)
      mouse.ChangeState(MouseState.EnteredObject);

    if (highlightsOnMouse)
      GetComponent<SpriteRenderer>().color = Color.red;
    mouse.SetLastObject(gameObject);

  }

  private void OnMouseExit()
  {
    if (mouse.GetCurrentState() != MouseState.WaitingForSecondObject)
      mouse.ChangeState(MouseState.ExitedObject);

    if (highlightsOnMouse)
      GetComponent<SpriteRenderer>().color = originalColor;
    mouse.SetLastObject(null);
  }

}
