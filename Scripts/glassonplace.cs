using UnityEngine;
using System.Collections;

public class glassonplace : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "waterglass" && Colliding.coltimer == 0)
        {
            col.gameObject.transform.parent = null;
            col.gameObject.transform.position = new Vector3(Position.xtr, -3.674f, 10.5F);
            col.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            Colliding.coltimer = 100;
        }
    }
}
