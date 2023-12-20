using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRoomDoor : MonoBehaviour
{
    public GameObject door;
    public bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activated)
        {
            Vector3 doorPosition = door.transform.position;
            doorPosition.y += 0.01f;
            door.transform.position = doorPosition;
        }
    }

    public void IncrementDoorPosition()
    {
        activated = true;
    }
}
