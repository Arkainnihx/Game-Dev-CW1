using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour {

    //x,y
    private List<List<Tile>> tiles;

    public GridController() {
        tiles = new List<List<Tile>>();
    }

    public void loadLevel(LevelSpec level) {
        //TODO: implement
        foreach (TileSpec spec in level) {
            var tile = Tile.Create(this, spec);
            tile.transform.position = new Vector3(spec.position.x, 0, spec.position.y);
        }
    }

    public void onPlayerMoveTo(Vector2 position) {
        //fetch appropriate tile and trigger walkover
        var column = tiles[(int)position.x];
        if (column != null) {
            var tile = column[(int)position.y];
            if (tile != null) {
                tile.onWalkOver();
            }
        }
    }

}
