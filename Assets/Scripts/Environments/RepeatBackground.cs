using UnityEngine;

/// <summary>
/// Repeats the background by resetting its position when it moves past a specified point.
/// </summary>
public class RepeatBackground : MonoBehaviour
{
    public float deviation;
    private Vector3 m_startPos;
    private float m_endWith;
}
