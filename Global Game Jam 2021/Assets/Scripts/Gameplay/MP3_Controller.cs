using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP3_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgm;

    public List<AudioClip> songs;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchSong(int i)
    {
      bgm.clip = songs[i];
      bgm.Play();
    }
}
