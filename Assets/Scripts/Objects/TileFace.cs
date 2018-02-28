using UnityEngine;

public abstract class TileFace : MonoBehaviour {

    protected GridController gridController;

    public static TileFace Create(GridController controller, TileFaceSpec spec) {
        //create the object itself
        var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.localScale = new Vector3(1, 0.05f, 1);

        //select correct implementation using spec
        TileFace component;
        switch (spec.kind) {
            default:
                component = obj.AddComponent<TileFaceNeutral>();
                break;
        }

        //bind controller and return
        component.gridController = controller;
        return component;
    }

    public abstract void OnWalkOver();

}
