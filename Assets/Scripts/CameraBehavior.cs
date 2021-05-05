using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // FindObjectOfType<CameraBehavior>().Rotate();
    public void Rotate()
    {
        transform.RotateAround(new Vector3(WoodStick.z / 2, 0, WoodStick.z / 2), new Vector3(0, -1, 0), 90);
    }

}
