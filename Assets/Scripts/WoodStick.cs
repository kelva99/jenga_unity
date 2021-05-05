using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodStick : MonoBehaviour
{
    public static readonly int x = 5;
    public static readonly int y = 3;
    public static readonly int z = 15;

    private bool isMouseDown = false;
    Vector3 diff;

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool posSet = false;


    // Start is called before the first frame update
    void Start()
    {
        diff = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (isMouseDown)
        {
            // update position
            transform.position = MousePosition() + diff;
        }
    }

    public void SetOriginalPosition()
    {
        if (!posSet)
        {
            originalPosition = transform.position;
            originalRotation = transform.rotation;
        }
    }

    public void RevertPosition()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }

    private void OnMouseDown()
    {
        isMouseDown = true;
        diff = transform.position - MousePosition();
        
    }

    private void OnMouseUp()
    {
        isMouseDown = false;
    }

    private Vector3 MousePosition()
    {
        Vector3 mousePosition2d = Input.mousePosition;
        mousePosition2d.z = Camera.main.WorldToScreenPoint(transform.position).z;
        // Debug.Log("2d " + mousePosition2d);
        return Camera.main.ScreenToWorldPoint(mousePosition2d);

    }

}
