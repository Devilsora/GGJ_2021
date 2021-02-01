using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endPanel;

    public bool startFadeIn;
    public CanvasGroup cg;
    public float alphaRate = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        cg = endPanel.GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startFadeIn && cg.alpha < 1f)
        {
          cg.alpha += alphaRate;  
        }
    }

    public void ShowEndPanel()
    {
      startFadeIn = true;
    }
}
