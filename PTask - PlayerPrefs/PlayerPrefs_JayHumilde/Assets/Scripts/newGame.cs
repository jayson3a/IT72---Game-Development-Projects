using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
  public void clickNewGame()
    {
        SceneManager.LoadScene("secondScene");
    }

    public void clickSettings()
    {
        SceneManager.LoadScene("fourthScene");
    }
}
