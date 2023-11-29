using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightToggle : MonoBehaviour
{
    public Light flashLight;
    public bool isOn = false;

    void Update()
    {
        GetComponent<Light>().enabled = isOn;
    }

    public void ToggleLight()
    {
        isOn = !isOn;
    }
}