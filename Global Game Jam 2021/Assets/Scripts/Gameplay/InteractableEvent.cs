using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum Interactable_Event_Type
{
  NA = -1,
  CREATE_OBJECT,
  DESTROY_SELF,
  ADD_ITEM,
  EVENT_LIST
}

[CreateAssetMenu(fileName = "New Interactable Event", menuName = "ScriptableObjects/Interaction Event", order = 1)]
public class InteractableEvent : ScriptableObject
{
  public Interactable_Event_Type eventType;

  //ignore areas if not applicable for event type
  public bool createsObject;
  public GameObject objectToCreate;
  

  public bool destroysSelf;

  public bool addsItem;
  public InventoryItem itemToAdd;

}


