using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    
    public enum InputEvent {None, Up, Down, Left, Right, Enter, Back}

    private bool _isEnabled = true;

    public InputEvent GetInput() {
        if (!_isEnabled) {
            return InputEvent.None;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            return InputEvent.Right;
        }
        if (Input.GetAxis("Horizontal") < 0) {
            return InputEvent.Left;
        }
        if (Input.GetAxis("Vertical") > 0) {
            return InputEvent.Up;
        }
        if (Input.GetAxis("Vertical") < 0) {
            return InputEvent.Down;
        }
        return InputEvent.None;
    }

    public void SetEnabled(bool val) {
        this._isEnabled = val;
    }
    
}
