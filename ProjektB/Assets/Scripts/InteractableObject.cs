using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string playerTag = "Player"; // Der erwartete Tag des Spielers
    public DialogueTrigger dialogueTrigger; // Das Trigger-Skript, das den Dialog auslöst

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                // Überprüfen Sie, ob das Trigger-Skript vorhanden ist
                if (dialogueTrigger != null)
                {
                    // Rufen Sie die TriggerDialogue-Methode im Trigger-Skript auf
                    dialogueTrigger.TriggerDialogue();
                }
                else
                {
                    Debug.LogError("DialogueTrigger script not assigned to InteractableObject.");
                }
            }
        }
    }
}
