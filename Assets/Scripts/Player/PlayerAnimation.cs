using System.Collections;
using UnityEngine;

/// <summary>
/// Handles player animations, including death, speed power-up effects, and other state-based animations.
/// Integrates with GameManager to manage game states and player interactions.
/// </summary>
public class PlayerAnimation
{
    private PlayerController m_playerController;
    private Animator m_playerAnim;
    private GameManager m_gameManager;
    private BoxCollider2D boxCollider;
}
