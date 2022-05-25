using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearZone : MonoBehaviour
{
    private float ClearZoneMinX = 3.3f;
    private float ClearZoneMinZ = 3.3f;

    // Update is called once per frame
    void Update()
    {
        if (InClearZone() && !ItemsRemain())
            Debug.Log("LEVEL COMPLETE");
    }

    private bool InClearZone()
    {
        if (transform.position.x >= ClearZoneMinX && transform.position.z >= ClearZoneMinZ)
            return true;

        return false;
    }

    private bool ItemsRemain()
    {
        int ItemsLeft = GameObject.FindGameObjectsWithTag("Item").Length;

        if (ItemsLeft > 0)
            return true;

        return false;
    }
}
