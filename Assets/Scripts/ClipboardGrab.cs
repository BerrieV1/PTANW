using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipboardGrab : MonoBehaviour
{
    public bool isGrabbed = false;
    public GameObject clipboard;
    public GameObject map;

    void Start()
    {
        map.SetActive(false);   
    }

    void Update()
    {
        if (isGrabbed)
        {
            Destroy(clipboard);
            map.SetActive(true);
        }
    }
}
