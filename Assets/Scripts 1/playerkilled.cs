using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerkilled : MonoBehaviour {
    [SerializeField]
    string sceneToLoad;
    private void OnCollisionEnter(Collision collision)
    {


        // This code gets called each frame player is inside trigger.
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("MainMenu");
        }
    }

}
