using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CustomToggle : MonoBehaviour
{
    public Button toggleButton;

    private bool toggleOn = true;

    public Sprite toggleOffSprite, toggleOnSprite;

    public delegate void OnToggle(bool visible);

    public static OnToggle onToggle;

    private void Awake()
    {
        toggleButton.onClick.AddListener(HandleTogglePressed);
    }

    void HandleTogglePressed()
    { 
        if(toggleOn == false)
        {
            toggleOn = true;
            toggleButton.GetComponent<Image>().sprite = toggleOnSprite;
        }
        else if(toggleOn == true)
        {
            toggleOn = false;
            toggleButton.GetComponent<Image>().sprite = toggleOffSprite;
        }

        onToggle.Invoke(toggleOn);
    }
}
