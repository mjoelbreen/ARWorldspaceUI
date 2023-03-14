using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordScript : MonoBehaviour
{
    private string password;
    public InputField inputField;
    public GameObject passwordMenu;
    public GameObject error;
    public GameObject mainMenu;
    public GameObject modeSelect;

    public void CheckPassword()
    {
        password = inputField.text;
        if(password == "12345")
        {
            ResetPasswordInput();
            mainMenu.SetActive(true);


        }
        else
        {
            error.SetActive(true);
            inputField.text = "";
        }
    }

    void ResetPasswordInput()
    {
        error.SetActive(false);
        inputField.text = "";
        passwordMenu.SetActive(false);
       }

    public void ReturnToMode()
    {
        ResetPasswordInput();
        modeSelect.SetActive(true);
    }
    
}
