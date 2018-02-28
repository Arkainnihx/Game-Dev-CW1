using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour {

    [Inject] private GridController _gridController;

    [Inject] private PlayerController _playerController;

    [Inject] private InputController _inputController;

    [SerializeField] private LevelSpec _level;

    // Use this for initialization
    private void Start() {
        _gridController.LoadLevel(_level);
        _playerController.gameController = this;
    }

    private void Update() {
        var input = _inputController.GetInput();
        switch (input) {
            case InputController.InputEvent.Up:
                PlayerMove(Vector2Int.up);
                break;
            case InputController.InputEvent.Down:
                PlayerMove(Vector2Int.down);
                break;
            case InputController.InputEvent.Left:
                PlayerMove(Vector2Int.left);
                break;
            case InputController.InputEvent.Right:
                PlayerMove(Vector2Int.right);
                break;
        }
    }

    private void PlayerMove(Vector2Int direction) {
        var targetPos = _playerController.Position + direction;
        if (_gridController.IsValidMove(targetPos)) {
            _inputController.SetEnabled(false);
            _playerController.Move(targetPos);
        }
    }

    public void OnPlayerMoved(Vector2Int position) {
        _gridController.OnPlayerMoveTo(position);
        //TODO: Wait for tile animations to finish before reenabling controls.
        _inputController.SetEnabled(true);
    }

}