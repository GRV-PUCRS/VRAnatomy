using Main.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DisableMovementInGrabInteractionController : MonoBehaviour
{
    [SerializeField] private GameObject _turnProviderInstance;

    public void OnInteractionStart(XRGrabInteractable interactable)
    {
        _turnProviderInstance.SetActive(false);
    }

    public void OnInteractionEnd(XRGrabInteractable interactable)
    {
        _turnProviderInstance.SetActive(true);
    }

    private void OnEnable()
    {
        EventManager.OnInteractionStart += OnInteractionStart;
        EventManager.OnInteractionEnd += OnInteractionEnd;
    }

    private void OnDisable()
    {
        EventManager.OnInteractionStart -= OnInteractionStart;
        EventManager.OnInteractionEnd -= OnInteractionEnd;
    }
}
