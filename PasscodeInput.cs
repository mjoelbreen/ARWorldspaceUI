using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasscodeInput : MonoBehaviour
{
   
    public TextMeshProUGUI input;
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private GameObject error;
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject passcodeBox;

    

   public void EvaluatePasscode()
    {
        
        if(input.text == "12345")
        {
            GoToMainMenu();
        }
        else
        {
            error.SetActive(true);
            input.text = "";
        }
    }

    void GoToMainMenu()
    {
        error.SetActive(false);
        passcodeBox.SetActive(false);
        mainMenu.SetActive(true);
        ResetPasscodeBox();
    }

    public void ResetPasscodeBox()
    {
        error.SetActive(false);
        input.text = "";
    }
   

 
}
