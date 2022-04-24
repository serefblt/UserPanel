using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] Text _resultText;
    [SerializeField] InputField _username, _password;
    LoginBase _loginBase = new LoginBase();
    [SerializeField] Button _loginButton;

    public void InputControllersLogin()
    {
        if (_username.text.Length < 6 || _password.text.Length < 6)
           
        {
            Debug.Log("false");
            _loginButton.interactable = false;
        }
        else
        {
            Debug.Log("true");
            _loginButton.interactable = true;
        }
    }


    public void LoginOnClick()
    {
        _loginBase.Login(_username.text, _password.text , _resultText);

        StartCoroutine(Logins());
    }

    IEnumerator Logins()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
