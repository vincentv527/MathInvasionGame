using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void goToControls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void goToAddition()
    {
        SceneManager.LoadScene("Addition");
    }
    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
