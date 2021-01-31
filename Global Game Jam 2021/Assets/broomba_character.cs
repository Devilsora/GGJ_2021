using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class broomba_character : MonoBehaviour
{
        public NPCConversation startConversation;
        public NPCConversation postBatteryConversation;

        public NPCConversation myConversation;

        private void OnMouseOver()
        {
            if(Input.GetMouseButtonDown(0))
            {
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }

  public void Update()
  {


  }
}
