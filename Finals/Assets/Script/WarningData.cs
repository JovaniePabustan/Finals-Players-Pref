using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarningData : MonoBehaviour
{
    public void clickCancel(){
        SceneManager.LoadScene("Second Scene");
    }
    public void clickReset(){
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("First Scene");
    }
}
