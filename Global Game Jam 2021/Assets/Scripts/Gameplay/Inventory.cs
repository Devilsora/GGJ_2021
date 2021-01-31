using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : Singleton<Inventory>
{
    public GameObject itemPrefab;
    List<InventoryItem> itemList = new List<InventoryItem>();
    public int invSize = 10;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.I))
      {
        Toggle();
      }
    }

    public List<InventoryItem> GetInventory()
    {
      return itemList;
    }

    public void AddToList(InventoryItem newItem)
    {
      if(itemList.Count < invSize)
      {
        //create object prefab to add to back of inventory, then add it to the list
        GameObject item = Instantiate(itemPrefab, transform);
        item.GetComponent<Image>().sprite = newItem.itemImage;
        item.GetComponent<InventoryItemButton>().SetItem(newItem);
        itemList.Add(newItem);

        Debug.Log("Added to inventory");
      }
      
      
    }

    public void Toggle()
    {
      float currAlpha = gameObject.GetComponent<CanvasGroup>().alpha;
      gameObject.GetComponent<CanvasGroup>().alpha = currAlpha == 1.0f ? 0.0f : 1.0f;

    }
}
