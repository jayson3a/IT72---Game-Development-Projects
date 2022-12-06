using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fakesetting : MonoBehaviour
{
    public void clickBacktoMain()
    {
        SceneManager.LoadScene("firstScene");
    }
}
