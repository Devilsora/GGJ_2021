using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP3_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgm;

    public List<AudioClip> songs;

    public bool spawned = false;  
    public GameObject rover;
    public GameObject eggPrefab;


    public List<int> keysPressed = new List<int>();

    //track which songs have been hit in which order
    //after that's done, make the egg spawn near the rover and make it clickable to create the ending scene

    void Awake()
    {
      rover = FindObjectOfType<RoverFollow>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    //check the order player plays songs in, then spawn

      if (keysPressed.Count == 3)
      {
        int size = keysPressed.Count - 1;

        int lastKey = keysPressed[2];
        int secondKey = keysPressed[1];
        int firstKey = keysPressed[0];

        if(lastKey == 1 && secondKey == 0 && firstKey == 2 && spawned == false)
        {
          spawned = true;
          eggPrefab.SetActive(true);
          eggPrefab.transform.position = rover.transform.position;
          Debug.Log("Spawn"); 
        }

        keysPressed.Clear();
      }

    }

    public void SwitchSong(int i)
    {
      bgm.clip = songs[i];
      bgm.Play();
      keysPressed.Add(i);
    }
}
