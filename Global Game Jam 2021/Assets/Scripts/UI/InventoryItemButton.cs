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

    public void SetItem(InventoryItem i)
    {
      item = i;
    }

    public void InventoryItemHandling()
    {
      mouse.SetLastObject(gameObject);
      mouse.ChangeState(MouseState.WaitingForSecondObject);
      mouse.SetItemTags(item.tagsToInteractWith);
    }
}
