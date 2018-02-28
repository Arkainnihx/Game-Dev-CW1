using System;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour {

    //x,y
    private Tile[,] _tiles;
    private int _minX = 0, _maxX = 0, _minY = 0, _maxY = 0;

    public void LoadLevel(LevelSpec level) {
        CheckLevelBounds(level);
        _tiles = new Tile[_maxX - _minX + 1, _maxY - _minY + 1];
        foreach (TileSpec spec in level) {
            var tile = Tile.Create(this, spec);
            tile.transform.position = new Vector3(spec.position.x, 0, spec.position.y);
            _tiles[spec.position.x - _minX, spec.position.y - _minY] = tile;
        }
    }

    public void OnPlayerMoveTo(Vector2Int position) {
        //fetch appropriate tile and trigger walkover
        _tiles[position.x - _minX, position.y - _minY].OnWalkOver();
    }

    public bool IsValidMove(Vector2Int targetPosition) {
        if (targetPosition.x < _minX
            || targetPosition.x > _maxX
            || targetPosition.y < _minY
            || targetPosition.y > _maxY) {
            return false;
        }

        if (_tiles[targetPosition.x - _minX, targetPosition.y - _minY] == null) {
            return false;
        }
        
        return true;
    }

    private void CheckLevelBounds(LevelSpec level) {
        foreach (TileSpec spec in level) {
            _minX = Math.Min(_minX, spec.position.x);
            _maxX = Math.Max(_maxX, spec.position.x);
            _minY = Math.Min(_minY, spec.position.y);
            _maxY = Math.Max(_maxY, spec.position.y);
        }
    }

}