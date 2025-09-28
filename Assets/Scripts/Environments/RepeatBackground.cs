using UnityEngine;

/// <summary>
/// Repeats the background by resetting its position when it moves past a specified point.
/// </summary>
public class RepeatBackground : MonoBehaviour
{
    public float deviation;
    private Vector3 m_startPos;
    private float m_endWith;

    void Start()
    {
        m_startPos = transform.position;
        m_endWith = GetComponent<BoxCollider>().size.x / deviation;
    }

    void Update()
    {
        if (transform.position.x < m_startPos.x - m_endWith)
        {
            transform.position = m_startPos;
        }
    }
}
