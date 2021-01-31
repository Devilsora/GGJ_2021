using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemButton : MonoBehaviour
{
    MouseHandler mouse;
    InventoryItem item;

    // Start is called before the first frame update
    void Start()
    {
      mouse = FindObjectOfType<MouseHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public InventoryItem GetItem()
    {
      return item;
    }

    public void SetItem(InventoryItem i)
    {
      item = i;
    }

    public void InventoryItemHandling()
    {
      mouse.ChangeState(MouseState.WaitingForSecondObject);
      mouse.SetItemInfo(item);
    }

    public void MouseEnter()
    {
      Debug.Log("M enter");
      mouse.ChangeState(MouseState.EnteredObject);
      mouse.SetLastObject(gameObject);
    }

    public void MouseExit()
    {
      Debug.Log("M leave");

      if(mouse.GetCurrentState() != MouseState.WaitingForSecondObject)
      {
        mouse.SetLastObject(null);
        mouse.ChangeState(MouseState.ExitedObject);
      }
    }
}
