using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages applying and removing blur effects on UI RawImages.
/// Allows dynamic switching between original and blurred materials for specified images.
/// </summary>
public class BlurRawImages : MonoBehaviour
{
    public GameObject[] Images;
    public Material[] BlurMaterial;
    private Material[] m_originalMaterials;
}
