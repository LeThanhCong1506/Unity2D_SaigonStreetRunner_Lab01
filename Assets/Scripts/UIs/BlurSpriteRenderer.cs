using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Manages applying and removing blur effects on SpriteRenderers in the scene.
/// Dynamically adjusts materials based on object names and tags to create a blur effect.
/// </summary>
public class BlurSpriteRenderer : MonoBehaviour
{
    public Material[] BlurMaterial;
    private Material[] m_originalMaterials;
    private GameObject[] m_findMoveLeft;
    private GameObject[] m_findStand;
}