using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CleaningRoom : MonoBehaviour
{
    public GameObject dirtyRoom;
    public GameObject cleanRoom;

    SpriteRenderer dirty;
    SpriteRenderer clean;

    public PlayerController player;
    public Rigidbody2D playerRB;

    public float alphaIncrease = 0.01f;

    //trigger object appearing on the room getting fully cleaned that gives the player the object to get to the next room
    public bool spawned = false;
    public GameObject rewardObject;
    public Vector3 spawnLocation;

    public NPCConversation startingOff;  

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        playerRB = player.gameObject.GetComponent<Rigidbody2D>();

        dirty = dirtyRoom.GetComponent<SpriteRenderer>();
        clean = cleanRoom.GetComponent<SpriteRenderer>();

        ConversationManager.Instance.StartConversation(startingOff);
  }

    // Update is called once per frame
    void Update()
    {
        if(playerRB.velocity != Vector2.zero)
        {
          Color oldDirt = dirty.color;
          Color newDirty = new Color(oldDirt.r, oldDirt.g, oldDirt.b, oldDirt.a - alphaIncrease);
          

          dirty.color = newDirty;
          

          if(!spawned && newDirty.a <= 1.0f)
          {
            spawned = true;
            rewardObject.SetActive(true);
          }

        }

        
    }
}
