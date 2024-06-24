using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using TMPro;

public class PlayfabManager : MonoBehaviour

{
    [Header("UI")]
    public Text messageText;
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;


    public void RegisterButton()
    {
        if (passwordInput.text.Length < 6)
        {
            messageText.text = "Password too short! Must be at least 6 characters";
            return;
        }

        var request = new RegisterPlayFabUserRequest
        {

            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        }; PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }
    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in";
    }
    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }

    public void LoginButton()
    { 
    
    }

    public void ResetPasswordButton()
    {
    
    }

    void OnPasswordReset(SendAccountRecoveryEmailResult result)
    { 
    
    }




        // Start is called before the first frame update
        void Start()
    {
       
    }

    // Update is called once per frame
    void Login()
    {
      //  var request = new LoginWithCustomIDRequest
      // {
      //      CustomId = SystemInfo.deviceUniqueIdentifier,
      //      CreateAccount = true
      //  };
      //  PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
      //
      //  void OnSuccess(LoginResult result)
      //  {
      //      Debug.Log("Login successful/account create");
      //  }

        void OnError(PlayFabError error)
        {
            Debug.Log("Error while login/account create");
            Debug.Log(error.GenerateErrorReport());
        }
    }
}
