using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TileFaceSpec {

   public  enum TileKind { NEUTRAL, FLIP }

    public TileKind kind;

    public Vector2[] tileRefs;
}
