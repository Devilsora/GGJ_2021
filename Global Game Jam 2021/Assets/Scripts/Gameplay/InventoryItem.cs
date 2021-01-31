using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "ScriptableObjects/Inventory", order = 1)]
public class InventoryItem : ScriptableObject
{
    public string objName;
    public List<string> tagsToInteractWith;
    public Sprite itemImage;
    // Start is called before the first frame update
    
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
