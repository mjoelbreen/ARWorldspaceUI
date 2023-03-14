using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProcedureButton : MonoBehaviour
{
    public TMP_Text procedureNameText;

    public GameObject buttonHighlight;

    public Button procedureButton;

    //public GameObject contentPrefab;

    int procedureListIndex = 0;

    private void Start()
    {
        procedureButton.onClick.AddListener(SetCurrentSelectedProcedureButton);
        procedureButton.onClick.AddListener(SetCurrentProcedureIndex);
        procedureButton.onClick.AddListener(SetCurrentProcedure);
    }

    public void SetProcedureNameText(string newName)
    {
        procedureNameText.text = newName;
    }

    public void SetProcedureListIndex(int index)
    {
        procedureListIndex = index;
    }

    

    public void ToggleButtonHighlight(bool enabled)
    {
        buttonHighlight.SetActive(enabled);
    }
    

    public void SetCurrentSelectedProcedureButton()
    {
        ProcedureSelectionUIHelper.instance.SetCurrentSelectedProcedureButton(this.gameObject);
    }

    public void SetCurrentProcedureIndex()
    {
        ProcedureManager.instance.SetCurrentProcedureIndex(procedureListIndex);
    }

    public void SetCurrentProcedure()
    {
        ProcedureManager.instance.SetCurrentProcedure(procedureListIndex);
    }
}
