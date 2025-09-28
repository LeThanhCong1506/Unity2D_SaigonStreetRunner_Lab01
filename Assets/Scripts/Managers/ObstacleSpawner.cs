using System.Collections;
using UnityEngine;

/// <summary>
/// Handles the spawning of obstacles at random positions and intervals.
/// Gradually increases the speed of obstacles over time to enhance difficulty.
/// Pauses obstacle spawning when speed power-ups are being spawned.
/// </summary>
public class ObstacleSpawner
{
    private GameManager m_gameManager;
    private GameObject[] m_obstaclePrefab;
    private ObjectPool[] m_obstaclePools;
    private float m_startDelay;
    private float m_repeatRate;
    private bool m_checkSpeed = false;
    public bool IsSpawningSpeedItem = false;
}
