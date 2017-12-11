using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public void EndButtonClicked()
    {
        // Load the next scene.
        SceneManager.LoadScene("MainMenu");
    }
}
