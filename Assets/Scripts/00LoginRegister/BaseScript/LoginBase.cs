using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginBase
{
    public void Login(string Username, string Password , Text _resultText)
    {
       
      string TempUsername =  PlayerPrefs.GetString("Username", Username);
        string TempPassword = PlayerPrefs.GetString("Password", Password);


        if (Username == TempUsername && Password == TempPassword)
        {
            _resultText.text = "Giris Basarili";

         
        }
        else
        {
            _resultText.text = "Giris Basarisiz";

        }


       

    }
   


}
