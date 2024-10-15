using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace Main.Utils
{
    public static class EventManager
    {
        public static Action<XRGrabInteractable> OnInteractionStart;
        public static Action<XRGrabInteractable> OnInteractionEnd;


        public static void TriggerOnInteractionStart(XRGrabInteractable interactable) => OnInteractionStart?.Invoke(interactable);
        public static void TriggerOnInteractionEnd(XRGrabInteractable interactable) => OnInteractionEnd?.Invoke(interactable);
    }
}
