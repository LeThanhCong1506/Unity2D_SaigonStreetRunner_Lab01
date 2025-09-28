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

    private readonly List<KeyCode> m_cheatBuffer = new List<KeyCode>();
    private readonly KeyCode[] m_cheatCode = new KeyCode[]
    {
        KeyCode.LeftArrow,
        KeyCode.LeftArrow,
        KeyCode.RightArrow,
        KeyCode.DownArrow,
        KeyCode.UpArrow
    };
    private readonly KeyCode[] m_unCheatCode = new KeyCode[]
{
    KeyCode.DownArrow,
    KeyCode.UpArrow,
    KeyCode.LeftArrow,
    KeyCode.RightArrow
};

    void Start()
    {
        IsOnGround = true;
        Gameover = false;
        AteSpeed = false;
        HackCheck = false;
        AteCoin = false;
        WaitTurn = false;

        m_playerRb = GetComponent<Rigidbody2D>();
        m_animator = GetComponent<Animator>();
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Physics2D.gravity = new Vector2(0, -9.81f);
        Physics2D.gravity *= GravityModifier;

        m_playerAnimation = new PlayerAnimation(this, m_animator, m_gameManager);
        m_playerMovement = new PlayerMovement(this, m_playerRb);
        m_playerCollision = new PlayerCollision(this, m_animator, m_playerAnimation);
        m_playerPowerUp = new PlayerPowerUp(this, m_playerAnimation);
    }

    void Update()
    {
        if (Gameover)
            return;

        m_playerMovement.UpdateDistance(ref m_distance, ref m_distanceToInt, SpeedPowerUpDuration, AteSpeed);
        DistanceToInt = m_distanceToInt;

        HandleCheatCode();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (HackCheck)
            {
                AudioManager.Instance.PlayHitSpeedUpSound();
                StartCoroutine(m_playerAnimation.WaitForStartSpeedPowerUp());
            }
        }

        if (AteSpeed)
            return;

        if (Input.GetKeyDown(KeyCode.UpArrow) && IsOnGround)
        {
            m_playerMovement.HandleJump();
        }
    }

    private void HandleCheatCode()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) m_cheatBuffer.Add(KeyCode.LeftArrow);
            else if (Input.GetKeyDown(KeyCode.RightArrow)) m_cheatBuffer.Add(KeyCode.RightArrow);
            else if (Input.GetKeyDown(KeyCode.DownArrow)) m_cheatBuffer.Add(KeyCode.DownArrow);
            else if (Input.GetKeyDown(KeyCode.UpArrow)) m_cheatBuffer.Add(KeyCode.UpArrow);
            else m_cheatBuffer.Clear(); // Nhấn phím khác thì reset

            // Giữ buffer không dài hơn cheat code dài nhất
            int maxCheatLength = Mathf.Max(m_cheatCode.Length, m_unCheatCode.Length);
            if (m_cheatBuffer.Count > maxCheatLength)
                m_cheatBuffer.RemoveAt(0);

            bool flowControl = CheckCheatCode();
            if (!flowControl)
            {
                return;
            }

            bool flowControl2 = CheckUnCheatCode();
            if (!flowControl2)
            {
                return;
            }
        }
    }

    private bool CheckUnCheatCode()
    {
        // Kiểm tra nếu buffer khớp cheat code mới
        if (m_cheatBuffer.Count == m_unCheatCode.Length)
        {
            bool matched = true;
            for (int i = 0; i < m_unCheatCode.Length; i++)
            {
                if (m_cheatBuffer[i] != m_unCheatCode[i])
                {
                    matched = false;
                    break;
                }
            }
            if (matched)
            {
                m_gameManager.CloseHackDisplay();
                HackCheck = false;
                Debug.Log("Cheat activated: New Combo!");
                m_cheatBuffer.Clear();
                return false;
            }
        }

        return true;
    }

    private bool CheckCheatCode()
    {
        // Kiểm tra nếu buffer khớp cheat code cũ
        if (m_cheatBuffer.Count == m_cheatCode.Length)
        {
            bool matched = true;
            for (int i = 0; i < m_cheatCode.Length; i++)
            {
                if (m_cheatBuffer[i] != m_cheatCode[i])
                {
                    matched = false;
                    break;
                }
            }
            if (matched)
            {
                m_gameManager.OpenHackDisplay();
                HackCheck = true;
                Debug.Log("Cheat unactivated!");
                m_cheatBuffer.Clear();
                return false;
            }
        }

        return true;
    }

    public void AddMoreDistance(int amount)
    {
        m_distance += amount;
    }

    public void IncreaseCountMeter(float amount)
    {
        SpeedPowerUpDuration += amount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_playerCollision.HandleCollision(collision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        m_playerPowerUp.HandleTrigger(collision);
    }
}
