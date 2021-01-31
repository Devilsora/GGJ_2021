using UnityEngine;
using UnityEngine.SceneManagement;

// ref: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html

public class StartHereClass : MonoBehaviour
{
    void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        // SceneManager.LoadScene("Scene3", LoadSceneMode.Additive);
        Debug.Log("Start here...");
    }

     void Update()
    {
      if(Input.GetKeyDown(KeyCode.N))
      {
        SceneManager.LoadScene("Scene3");
        Debug.Log("Update, N key pushed...");
      }
    }


}
