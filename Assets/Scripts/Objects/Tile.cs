using UnityEngine;

public class Tile : MonoBehaviour {

    private TileFace upper, lower;

    public static Tile Create(GridController controller, TileSpec spec) {
        var tile = new GameObject().AddComponent<Tile>();

        tile.upper = TileFace.Create(controller, spec.upper);
        tile.upper.transform.parent = tile.transform;
        tile.upper.transform.localPosition = new Vector3(0, 0.025f, 0);

        tile.lower = TileFace.Create(controller, spec.lower);
        tile.lower.transform.parent = tile.transform;
        tile.lower.transform.localPosition = new Vector3(0, -0.025f, 0);

        return tile;
    }

    public void Flip() {
        TileFace tmp = upper;
        upper = lower;
        lower = tmp;
        //TODO: also flip the object
    }

    public void OnWalkOver() {
        this.upper.OnWalkOver();
    }
}
