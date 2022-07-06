using System;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(HoverEnterEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Hover Enter by: " + interactor);
    }

    public void LogHoverExit(HoverExitEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Hover Exit by: " + interactor);
    }

    public void LogSelect(SelectEnterEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Selected by: " + interactor);
    }

    public void LogDeselect(SelectExitEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Deselected by: " + interactor);
    }

    public void LogActivate(ActivateEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Activated by: " + interactor);
    }

    public void LogDeactivate(DeactivateEventArgs interactor)
    {
        Debug.Log(gameObject.name + " Deactivated by: " + interactor);
    }
}

