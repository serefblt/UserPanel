using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Text _randomNumberText, _userListText;
    [SerializeField] InputField _username;
    Dictionary<string, int> _userList = new Dictionary<string, int>();
    int random;



    public void RandomTextOnClick()
    {
        random = Random.Range(1, 1000000);
        _randomNumberText.text = random.ToString();
    }

    public void SaveUserAndScore()
    {
        _userList.Add(PlayerPrefs.GetString("Username"), random); 
    }
    
    public void GetUserList()
    {
        foreach (var item in _userList)
        {
            Debug.Log(item);
            _userListText.text += ("\n") + item.ToString();
        }
    }

    public void ChangeUser()
    {
        PlayerPrefs.SetString("Username", _username.text);
    }
}
