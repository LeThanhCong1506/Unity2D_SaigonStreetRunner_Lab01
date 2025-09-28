using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the player's core behavior, including movement, collision handling, and power-up interactions.
/// Integrates with other components such as PlayerAnimation, PlayerMovement, and PlayerPowerUp to handle specific functionalities.
/// </summary>
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D m_playerRb;
    private Animator m_animator;
    public float JumpForce;
    public float GravityModifier;
    private float m_distance = 0;
    public float Speed = 2;
    private int m_distanceToInt = 0;
    public float SpeedPowerUpDuration = 2;

    [HideInInspector] public bool IsOnGround;
    [HideInInspector] public bool Gameover;
    [HideInInspector] public float Distance;
    [HideInInspector] public int DistanceToInt;
    [HideInInspector] public bool AteSpeed;
    [HideInInspector] public bool HackCheck;
    [HideInInspector] public bool AteCoin;
    [HideInInspector] public bool WaitTurn;

    private PlayerMovement m_playerMovement;
    private PlayerCollision m_playerCollision;
    private PlayerPowerUp m_playerPowerUp;
    private PlayerAnimation m_playerAnimation;
    private GameManager m_gameManager;
}
