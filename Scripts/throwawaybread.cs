using UnityEngine;
using System.Collections;

public class throwawaybread : MonoBehaviour {

    public Colliding takeslices;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (takeslices.inputobjects.Contains(col.gameObject) && col.gameObject.name != "breadknife")
        {
            col.gameObject.transform.parent = null;
            col.gameObject.transform.parent = gameObject.transform;
            col.gameObject.transform.localPosition = new Vector3(-0.64f, 0.371f, 1.25f);
            col.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
            next.lvl3Score -= 10;
            //Colliding.coltimer = 200;
        }



    }

}
