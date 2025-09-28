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

    public ObjectPool(GameObject prefab, int initialSize, Transform parent = null)
    {
        m_prefab = prefab;
        m_parent = parent;
        for (int i = 0; i < initialSize; i++)
        {
            var obj = Object.Instantiate(m_prefab, m_parent);
            obj.SetActive(false);
            m_pool.Enqueue(obj);
        }
    }

    public GameObject Get(Vector3 position, Quaternion rotation)
    {
        GameObject obj;
        if (m_pool.Count > 0)
        {
            obj = m_pool.Dequeue();
        }
        else
        {
            obj = Object.Instantiate(m_prefab, m_parent);
        }
        obj.transform.position = position;
        obj.transform.rotation = rotation;
        obj.GetComponent<MoveLeft>().Speed = GameObject.Find("Grounds").GetComponent<MoveLeft>().Speed;
        obj.SetActive(true);
        return obj;
    }

    public void Return(GameObject obj)
    {
        obj.SetActive(false);
        m_pool.Enqueue(obj);
    }
}
