using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainMP3 : MonoBehaviour
{
    public GameObject MP3;
    public bool given;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(!given)
        {
          MP3.SetActive(true);
          given = true;
        }
        
    }
}
