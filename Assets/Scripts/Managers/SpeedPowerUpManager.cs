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

    public SpeedPowerUpManager(GameManager manager, GameObject[] prefab, ObstacleSpawner obstacleSpawner)
    {
        m_gameManager = manager;
        m_eatPrefab = prefab;
        m_obstacleSpawner = obstacleSpawner;

        m_eatPool = new ObjectPool[m_eatPrefab.Length];
        for (int i = 0; i < m_eatPrefab.Length; i++)
        {
            m_eatPool[i] = new ObjectPool(m_eatPrefab[i], 2);
        }
    }

    public void StartSpawning()
    {
        m_gameManager.StartCoroutine(RandomSpawnSpeedPrefabs());
    }

    private IEnumerator RandomSpawnSpeedPrefabs()
    {
        while (!m_gameManager.m_playerControllerScript.Gameover)
        {
            var randomTime = Random.Range(5.0f, 11.0f);
            yield return new WaitForSeconds(randomTime);

            m_obstacleSpawner.IsSpawningSpeedItem = true;

            Vector3 spawnPos = new Vector3(15, Random.Range(-2.7f, 0.7f), 0);
            int eatIndex = Random.Range(0, m_eatPrefab.Length);
            Debug.Log(eatIndex);
            var powerUp = m_eatPool[eatIndex].Get(spawnPos, m_eatPrefab[eatIndex].transform.rotation);

            powerUp.GetComponent<MoveLeft>().OnOutOfScreen += () => m_eatPool[eatIndex].Return(powerUp);

            yield return new WaitForSeconds(1);
            m_obstacleSpawner.IsSpawningSpeedItem = false;
        }
    }
}
