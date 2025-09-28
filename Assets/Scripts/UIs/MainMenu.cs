using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Manages the main menu functionality, including starting the game, handling UI interactions,
/// and managing transitions to other scenes. Integrates with SaveManager and AudioManager for state persistence and audio feedback.
/// </summary>
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject m_loadingScreen;
    [SerializeField] private Slider m_loadingSlider;
    [SerializeField] private Sprite[] m_loadingImages;
    [SerializeField] private GameObject m_background;
    [SerializeField] private GameObject m_background1;
    [SerializeField] private GameObject m_setting;
    [SerializeField] private GameObject m_instruction;
    [SerializeField] private GameObject m_rank;
    [SerializeField] private GameObject m_credit;
    [SerializeField] private GameObject m_darkOverlay;
    [SerializeField] private GameObject m_blur;
}
