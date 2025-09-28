using UnityEngine;

/// <summary>
/// Handles the player's movement, including jumping, bending, and updating the distance traveled.
/// Integrates with the PlayerController to manage movement-related states and animations.
/// </summary>
public class PlayerMovement
{
    private PlayerController playerController;
    private Rigidbody2D playerRb;
    private float endHeight;
}
