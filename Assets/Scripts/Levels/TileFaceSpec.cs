using System;
using UnityEngine;

[Serializable]
public class TileFaceSpec {

   public  enum TileKind { NEUTRAL, FLIP }

    public TileKind kind;

    public Vector2Int[] tileRefs;
}
