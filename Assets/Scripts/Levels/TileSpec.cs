using System;
using UnityEngine;

[Serializable]
public class TileSpec {
    
    public Vector2Int position;

    public TileFaceSpec upper, lower;

}
