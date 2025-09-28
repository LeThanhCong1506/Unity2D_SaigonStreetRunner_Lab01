using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

/// <summary>
/// Manages the overall game flow, including spawning obstacles, handling power-ups,
/// updating UI elements, and managing game states such as pause and game over.
/// </summary>
public class GameManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefab;
    public GameObject[] EatPrefab;
    public float StartDelay = 2;
    public float RepeatRate = 2;
    //public UIDocument UIDoc;

    [HideInInspector] public bool IsPause;
    [SerializeField] private GameObject m_gameOver;
    [SerializeField] private GameObject m_darkOverlay;
    [SerializeField] private GameObject m_pauseButton;
    [SerializeField] private GameObject m_resumeButton;
    [SerializeField] private TextMeshProUGUI m_currentDistanceLabel;
    [SerializeField] private TextMeshProUGUI m_bestDistanceLabel;
    [SerializeField] private TextMeshProUGUI m_distanceLabel;
    [SerializeField] private TextMeshProUGUI m_hackMeterLabel;
    [HideInInspector] public PlayerController m_playerControllerScript;
    [HideInInspector] public BlurSpriteRenderer m_blurManager;

    private ObstacleSpawner m_obstacleSpawner;
    private SpeedPowerUpManager m_speedPowerUpManager;
    private UIManager m_uiManager;
    private bool m_appliedBlur;
}
