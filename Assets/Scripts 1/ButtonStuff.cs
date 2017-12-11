using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStuff : MonoBehaviour, IActivatable
{

    [SerializeField]
    private string nameText;



    private MeshRenderer meshRenderer;
    
    private Collider collider;
    public string NameText
    {
        get
        {
            return nameText;
        }
    }


    // Use this for initialization
    void Start()

    {
        
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
    }
    public void DoActivate()
    {


        // Doing this rather than destroy because our Inventory menu still needs
        // to know about this object even though it has been collected and 
        // removed from the 3D world.
        // Also, if you wanted to add sound effects here,
        // and we destroy before the sfx are done, it will not sound correct.
        // Just like how coin worked in our 2D project!
       
        
            // Load the next scene.
            SceneManager.LoadScene("MainMenu");
        
    }


}
