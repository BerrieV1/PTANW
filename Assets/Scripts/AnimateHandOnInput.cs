using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty gripAction;
    public Animator handAnimator;
    void Start()
    {
        
    }
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
