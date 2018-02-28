using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Level", menuName = "Game/Level")]
[System.Serializable]
public class LevelSpec : ScriptableObject, IEnumerable<TileSpec> {
    
    public TileSpec[] tiles;

    public IEnumerator<TileSpec> GetEnumerator() {
        return ((IEnumerable<TileSpec>) tiles).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
