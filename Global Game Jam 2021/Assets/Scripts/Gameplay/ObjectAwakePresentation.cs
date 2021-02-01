using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAwakePresentation : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
  
    // Start is called before the first frame update
    void Awake()
    {
      source = GetComponent<AudioSource>();
      source.clip = clip;
      source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
