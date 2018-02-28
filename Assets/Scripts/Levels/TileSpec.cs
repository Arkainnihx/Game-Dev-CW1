using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[Serializable]
public class TileSpec {
    
    public Vector2 position;

    public TileFaceSpec upper, lower;

}
