﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public Vector3Int pos;
    public virtual void Interact(SrpgClass srpgClass)
    {
        Debug.LogError("Need Override Interact function");
    }
}
