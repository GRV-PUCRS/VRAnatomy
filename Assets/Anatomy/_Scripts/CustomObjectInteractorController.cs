using Main.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(XRGrabInteractable))]
public class CustomObjectInteractorController : MonoBehaviour
{
    private void OnEnable()
    {
        var interactor = GetComponent<XRGrabInteractable>();

        interactor.selectEntered.AddListener((args) => EventManager.TriggerOnInteractionStart(interactor));
        interactor.selectExited.AddListener((args) => EventManager.TriggerOnInteractionEnd(interactor));
    }

    private void OnDisable()
    {
        var interactor = GetComponent<XRGrabInteractable>();

        interactor.selectEntered.RemoveListener((args) => EventManager.TriggerOnInteractionStart(interactor));
        interactor.selectExited.RemoveListener((args) => EventManager.TriggerOnInteractionEnd(interactor));
    }
}
