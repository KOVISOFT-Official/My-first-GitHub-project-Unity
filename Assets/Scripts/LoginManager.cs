using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField userNameInput;
    public TMP_InputField passwordInput;

    string correctUserName = "admin";
    string correctPassword = "123";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login(){
        string enteredUserName = userNameInput.text;
        string enteredPassword = passwordInput.text;

        if (enteredPassword == correctPassword && enteredUserName == correctUserName)
        {
            Debug.Log("Login Success!");
        }
        else
        {
            Debug.Log("Login Faild!");
        }
    }
}
