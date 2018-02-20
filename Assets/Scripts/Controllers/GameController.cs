using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour {

    [Inject]
    private GridController gridController;

    [SerializeField]
    public LevelSpec level;

	// Use this for initialization
	void Start () {
        gridController.loadLevel(level);	
	}
}
