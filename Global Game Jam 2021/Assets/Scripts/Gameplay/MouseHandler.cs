using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
  GameObject lastClickedObject;
  
  public GameObject GetLastObject()
  {
    return lastClickedObject;
  }

  public void SetLastObject(GameObject obj)
  {
    lastClickedObject = obj;
  }


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //if (Input.GetMouseButtonDown(0))
    //{
    //  Debug.Log("Mouse handler down");
    //  Vector3 workingPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
    //  RaycastHit2D hit = Physics2D.Raycast(workingPoint, Vector2.zero);
    //
    //  if (hit.collider != null)
    //  {
    //    Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
    //  }
    //  else
    //  {
    //    Debug.Log("Nothing clicked");
    //  }
    //}

  }
}
  
    

    

