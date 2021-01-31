using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : Singleton<Inventory>
{
    public static Inventory instance;

    public GameObject itemPrefab;
    List<InventoryItem> itemList = new List<InventoryItem>();
    public Transform UI;
    public int invSize = 10;
  
    // Start is called before the first frame update
    void Awake()
    {
      DontDestroyOnLoad(gameObject);
      SceneManager.sceneLoaded += OnSceneLoaded;
    }

  void OnDisable()
    {
      
      SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
      UI = GameObject.Find("Inventory").transform;
    }

    // Update is called once per frame
  void Update()
    {
      if(Input.GetKeyDown(KeyCode.I))
      {
        Toggle();
      }
    }

    public int GetItemIndex(InventoryItem item)
    {
        for(int i = 0; i < itemList.Count; i++)
        {
          if (item == itemList[i])
            return i;
        }

      return -1;
    }

    public void RemoveItem(InventoryItem item)
    {
        if(itemList.Contains(item))
        {
          //go through children and delete item in inventory list

          for(int i = 0; i < transform.childCount; i++)
          {
            if(transform.GetChild(i).gameObject.GetComponent<InventoryItemButton>().GetItem() == item)
            {
              Destroy(transform.GetChild(i).gameObject);
              break;
            }
          }

          itemList.Remove(item);
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
        GameObject item = Instantiate(itemPrefab, UI);
        item.GetComponent<Image>().sprite = newItem.itemImage;
        item.GetComponent<InventoryItemButton>().SetItem(newItem);
        itemList.Add(newItem);

        Debug.Log("Added to inventory");
      }
    }

    public void Toggle()
    {
      float currAlpha = UI.gameObject.GetComponent<CanvasGroup>().alpha;
      UI.gameObject.GetComponent<CanvasGroup>().alpha = currAlpha == 1.0f ? 0.0f : 1.0f;

    }
}
