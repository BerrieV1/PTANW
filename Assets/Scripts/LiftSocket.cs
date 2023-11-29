using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LiftSocket : MonoBehaviour
{
    private Vector3 desiredScale = new Vector3(2f, 2f, 2f);


    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        XRBaseInteractable interactable = args.interactable;

    }


}
