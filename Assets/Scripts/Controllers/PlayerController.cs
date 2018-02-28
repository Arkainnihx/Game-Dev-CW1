using System;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private const float PlayerY = 0.075f;
	private const float JourneyTime = 0.2f;
	
	public Vector2Int Position { get; private set; }
	public GameController gameController;
	private Vector2Int _targetPos;
	private Vector3 _previousPos3, _targetPos3;
	private float _startTime;
	private bool _isMoving = false;

	public void Move(Vector2Int targetPos) {
		_targetPos = targetPos;
		_targetPos3 = ToWorldSpace(_targetPos);
		_startTime = Time.time;
		_isMoving = true;
	}

	private static Vector3 ToWorldSpace(Vector2Int position) {
		return new Vector3(position.x, PlayerY, position.y);
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_isMoving) {
			var moveVal = Math.Min((Time.time - _startTime) / JourneyTime, 1f);
			transform.position = Vector3.Slerp(_previousPos3, _targetPos3, moveVal);
			if (moveVal == 1f) {
				_isMoving = false;
				_previousPos3 = _targetPos3;
				Position = _targetPos;
				gameController.OnPlayerMoved(Position);
			}	
		}
	}
}
