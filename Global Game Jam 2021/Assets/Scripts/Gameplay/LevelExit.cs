﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{

   public int nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("Next level");
    //Scene
  }
}
