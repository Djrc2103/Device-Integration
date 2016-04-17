using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class lvl1 : MonoBehaviour {
    //Scene scene = SceneManager.GetActiveScene();
    // Use this for initialization




    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }

        if (Input.GetKeyDown("escape"))
        {

            Application.Quit();
        }

        }
}
