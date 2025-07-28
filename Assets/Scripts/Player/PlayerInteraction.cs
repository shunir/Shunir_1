using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable interactable;

    void Update()
    {
        if (interactable != null && Input.GetKeyDown(KeyCode.E))
            interactable.Interact();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable obj))
            interactable = obj;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (interactable != null && other.gameObject == ((MonoBehaviour)interactable).gameObject)
            interactable = null;
    }
}
