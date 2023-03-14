using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;

    private GameObject currentActivePanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetCurrentActivePanel(GameObject newPanel)
    {
        CloseCurrentPanel();
        currentActivePanel = newPanel;
    }

    public void CloseCurrentPanel()
    {
        if (currentActivePanel != null)
        {
            if (currentActivePanel.gameObject.activeSelf == true)
            {
                currentActivePanel.SetActive(false);
                currentActivePanel = null;
            }
        }
    }


}
