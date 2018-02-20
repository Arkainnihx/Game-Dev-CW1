using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerMovementSettings", menuName = "Settings/PlayerMovementSettings")]
public class PlayerMovementSettings : ScriptableObject {
    
    [SerializeField]
    public float animMoveSpeed = 1f;
}
