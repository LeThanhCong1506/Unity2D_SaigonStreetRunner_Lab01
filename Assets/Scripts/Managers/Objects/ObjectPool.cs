using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Implements a generic object pooling system for GameObjects.
/// Efficiently reuses inactive objects instead of instantiating and destroying them repeatedly,
/// improving performance for frequently spawned and recycled objects such as obstacles or effects.
/// </summary>
public class ObjectPool
{
    private GameObject m_prefab;
    private Queue<GameObject> m_pool = new Queue<GameObject>();
    private Transform m_parent;
}
