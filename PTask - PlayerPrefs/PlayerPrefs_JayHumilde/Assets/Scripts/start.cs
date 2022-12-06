using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public InputField textBox;
    public void clickStart()
    {
        PlayerPrefs.SetString("username", textBox.text);
        SceneManager.LoadScene("thirdScene");
    }

    public void clickBack()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("firstScene");
    }
    public void clickBackAgain()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("secondScene");
    }
}
