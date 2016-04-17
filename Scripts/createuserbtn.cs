using UnityEngine;
using System.Collections;

public class createuserbtn : MonoBehaviour {

    public GameObject button;
    public GameObject canvas;
    public GameObject newuser;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            newuser = (GameObject)Instantiate(button, new Vector3(0, 0, 0), Quaternion.identity);
            newuser.transform.parent = canvas.transform;
            newuser.transform.localPosition = new Vector3(-650f, 306f, 0);
        }

    }
}
