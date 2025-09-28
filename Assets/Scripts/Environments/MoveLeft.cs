using System;
using UnityEngine;

/// <summary>
/// Moves the GameObject to the left at a specified speed.
/// Stops movement when the game is over.
/// </summary>
public class MoveLeft : MonoBehaviour
{
    public float Speed;
    private PlayerController m_playerControllerScript;
    public event Action OnOutOfScreen;
}
