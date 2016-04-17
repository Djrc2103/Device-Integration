using UnityEngine;
using System.Collections;

public class coffeereconplac3 : MonoBehaviour {
    public Vector3 origpos;

    // Use this for initialization
    void Start () {
        GameObject.Find("coffeerec").transform.parent = null;
        origpos = GameObject.Find("coffeerec").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "coffeerec" && Colliding.coltimer == 0)
        {
            
            col.gameObject.transform.parent = null;
            col.gameObject.transform.position = origpos;
            col.gameObject.transform.eulerAngles = new Vector3(-90.0f, 180.0f, 0);
            Colliding.coltimer = 200;
        }
    }


}
