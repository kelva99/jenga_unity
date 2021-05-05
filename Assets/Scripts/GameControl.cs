using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static readonly int totalStick = 54;
    public static readonly int stickPerLayer = 3;
    public WoodStick woodstick;

    // public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        // parent = transform.Find("WoodStickCollection");
        for(int h = 0; h < totalStick/stickPerLayer; h++)
        {
            for(int i = 0; i < stickPerLayer; i++)
            {
                WoodStick locStick;
                locStick = Instantiate(woodstick);
                // locStick.transform.parent = parent;

                if (h % 2 == 0)
                {
                    locStick.transform.position += new Vector3((WoodStick.x * i), (WoodStick.y * h), 0);
                }
                else 
                {
                    locStick.transform.position += new Vector3((WoodStick.x * i), (WoodStick.y * h), -WoodStick.z);
                    locStick.transform.RotateAround(transform.position, new Vector3(0, -1, 0), 90);

                }
                locStick.SetOriginalPosition();
            }
        }
    }

    public void Restart()
    {
        var sticks = FindObjectsOfType<WoodStick>();
        /*
        // Debug.Log(sticks.Length);
        foreach(WoodStick ws in sticks)
        {
            foreach(Transform ts in ws.transform)
            {
                Destroy(ts.gameObject);
            }
            ws.gameObject.SetActive(false);
            Destroy(ws);
        }
        Start();
        */
        foreach (WoodStick ws in sticks)
        {
            ws.RevertPosition();
        }

    }


}
