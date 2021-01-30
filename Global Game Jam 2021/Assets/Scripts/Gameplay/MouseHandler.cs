using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MouseState
{
  Idle,
  EnteredObject,
  ClickedObject,
  ExitedObject,
  WaitingForSecondObject,
  SecondObjectInvalid
}

public class MouseHandler : MonoBehaviour
{
  GameObject lastClickedObject;
  List<string> itemUseTags = new List<string>();
  float idleTime = 0.01f;
  float idleTimer = 0.0f;

  [SerializeField]
  MouseState currentState = MouseState.Idle;

  public GameObject GetLastObject()
  {
    return lastClickedObject;
  }

  public void SetLastObject(GameObject obj)
  {
    lastClickedObject = obj;
  }

  public void ChangeState(MouseState s)
  {
    currentState = s;
    idleTimer = 0.0f;
  }

  public MouseState GetCurrentState()
  {
    return currentState;
  }

  public void SetItemTags(List<string> tags)
  {
    itemUseTags = tags;
  }

  public List<string> GetItemTags()
  {
    return itemUseTags;
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if(currentState != MouseState.WaitingForSecondObject)
    {
      idleTimer += Time.deltaTime;

      if (idleTime > idleTimer && currentState != MouseState.Idle)
        currentState = MouseState.Idle;
    }
    
   
  }
}
  
    

    

