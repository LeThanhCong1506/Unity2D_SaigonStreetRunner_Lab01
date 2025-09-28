using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the behavior of UI buttons that toggle sound and VFX settings.
/// Updates the button's sprite based on the current volume state and handles user interactions to toggle these states.
/// </summary>
public class ChangeButtonSprite : MonoBehaviour
{
    [SerializeField] private Sprite m_normalSprite;
    [SerializeField] private Sprite m_pressedSprite;

    private Button m_button;
    private Image m_buttonImage;
    private VolumeSettings m_volumeSettings;
    private bool m_isVFXButton;
    private bool m_isSoundButton;
}
