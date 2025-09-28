using System.Collections;
using UnityEngine;

/// <summary>
/// Manages the spawning of speed power-ups at random intervals and positions.
/// Temporarily pauses obstacle spawning while a speed power-up is being spawned.
/// </summary>
public class SpeedPowerUpManager
{
    private GameManager m_gameManager;
    private GameObject[] m_eatPrefab;
    private ObjectPool[] m_eatPool;
    private ObstacleSpawner m_obstacleSpawner;
}
