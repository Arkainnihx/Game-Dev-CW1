using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SphereSize : MonoBehaviour {

    [Inject]
    private PlayerMovementSettings settings;

	// Use this for initialization
	void Start () {
        Debug.Log(settings.animMoveSpeed);
        this.transform.localScale = settings.animMoveSpeed * Vector3.one;
	}
}
