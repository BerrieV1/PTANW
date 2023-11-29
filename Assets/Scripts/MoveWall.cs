using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Adjust the speed as needed
    private bool placed = false;

    void Update()
    {
        if(placed)
        {
            while (transform.position.y < 5.15)
            {
                transform.position += new Vector3(0, 0.0005f, 0);
            }
            placed = false;
        }

    }

    public void SetBoolToTrue()
    {
        placed = true;
    }


}
